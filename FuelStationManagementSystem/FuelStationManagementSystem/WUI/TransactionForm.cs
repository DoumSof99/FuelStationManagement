using DevExpress.XtraGrid;
using FuelStationManagementSystem.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationManagementSystem.WUI
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        public SqlConnection Con { get; set; }
        public Guid CustomerId { get; set; }

        BindingList<TransactionLine> _TransactionLines = new BindingList<TransactionLine>();
        private int _FuelCount = 0;
        private bool _HasDiscount = false;
        private const decimal _DiscountRate = 0.10m;

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            PopulateCustomerId();
            Utility.PopulateUtility(Con, Resource.QPopulateTransaction, gridItems);
        }

        private void ctrlItemType_SelectedValueChanged(object sender, EventArgs e) {
            string Myquery = String.Format(Resource.QTransactionFilterByItem, ctrlItemType.SelectedItem.ToString());
            Utility.PopulateUtility(Con, Myquery, gridItems);
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Utility.PopulateUtility(Con, Resource.QPopulateTransaction, gridItems);
        }
        private void btnAddItem_Click(object sender, EventArgs e) {
            AddItems();
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }


        private void PopulateCustomerId()
        {
            ctrlCustomerID.Text = Convert.ToString(CustomerId);
        }

        private void AddItems() {                            
            Guid itemID = Guid.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("ID")));

            int itemQuantity = Convert.ToInt32(ctrlQuantity.Text);

            string itemType = Convert.ToString(gridViewItems.GetFocusedRowCellValue("ItemType"));
            if (itemType == "Fuel")
            {
                _FuelCount += 1;
                itemQuantity = 1;
            }

            decimal itemPrice = decimal.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("Price")));
            decimal itemCost = decimal.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("Cost")));
            decimal value = itemQuantity * itemPrice;
            decimal cost = itemQuantity * itemCost;
            
            if (_FuelCount == 1 && itemPrice > 50) {
                _HasDiscount = true;
            }

            if (_FuelCount > 1) {
                MessageBox.Show("You have already chosen Fuel!");
            }
            else {
                TransactionLine newTransactionLine = new TransactionLine(itemID, itemQuantity, itemPrice, value, itemCost, cost, itemType);
                _TransactionLines.Add(newTransactionLine);
                
                gridTransactionLines.DataSource = _TransactionLines;

                CalculateTotalValues();
            }           
        }

        private void DeleteItem()
        {
            Guid id = Guid.Parse(Convert.ToString(gridViewTransactionLines.GetFocusedRowCellValue("ID")));
            string itemType = Convert.ToString(gridViewTransactionLines.GetFocusedRowCellValue("ItemType"));

            _TransactionLines.Remove(_TransactionLines.First(x=>x.ID==id));           
            if (itemType == "Fuel")
            {
                _FuelCount = 0;
                _HasDiscount = false;
            }            

            CalculateTotalValues();
        }

        private void CalculateTotalValues()
        {
            decimal totalValue = _TransactionLines.Sum(x => x.Value);
            ctrlTotalValue.Text = Convert.ToString(totalValue);

            decimal totalCost = _TransactionLines.Sum(x => x.Cost);
            ctrlTotalCost.Text = Convert.ToString(totalCost);

            decimal discount = 0;
            decimal discountValue = 0;
            if (_HasDiscount)
            {
                discount = totalValue * _DiscountRate;
                discountValue = totalValue - discount;
            }
            else
            {
                discountValue = totalValue;
            }

            ctrlDiscountValue.Text = Convert.ToString(discountValue);
        }

        private void AddTransaction()
        {
            if (_TransactionLines.Count == 0)
            {
                MessageBox.Show("Please select Items!");
            }
            else {
                Transaction newTransaction = new Transaction(
                    CustomerId,
                    Convert.ToDecimal(ctrlDiscountValue.Text),
                    Convert.ToDecimal(ctrlTotalValue.Text),
                    Convert.ToDecimal(ctrlTotalCost.Text)
                );

                try {
                    Con.Open();
                    string MyQeury = String.Format(Resource.QAddTransaction, newTransaction.ID, newTransaction.GetDate(), newTransaction.CustomerID, newTransaction.DiscountValue, newTransaction.TotalValue, newTransaction.TotalCost);
                    SqlCommand cmd = new SqlCommand(MyQeury, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction Succesfully Added");
                    
                    Con.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }

                AddTransactionLines(newTransaction);
            }          
        }

        private void AddTransactionLines(Transaction newTransaction) {
            foreach (var item in _TransactionLines) {
                item.TransactionID = Convert.ToString(newTransaction.ID);
                try {
                    Con.Open();
                    string MyQuery = String.Format(Resource.QAddTransactionLines, item.ID, Convert.ToString(item.TransactionID), Convert.ToString(item.ItemID), item.Quantity, item.ItemPrice, item.Value, item.ItemCost, item.Cost, item.ItemType);
                    SqlCommand cmd = new SqlCommand(MyQuery, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }

            _TransactionLines.Clear();
        }

        private void btnViewTransaction_Click(object sender, EventArgs e) {
            ViewTransactionForm viewTransaction = new ViewTransactionForm();
            viewTransaction.Con = Con;
            viewTransaction.ShowDialog();
        }

    }
}
