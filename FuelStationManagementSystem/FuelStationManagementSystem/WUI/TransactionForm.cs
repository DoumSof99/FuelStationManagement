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
            PopulateItems();            
        }

        private void ctrlItemType_SelectedValueChanged(object sender, EventArgs e) {
            FilterByItemType();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            PopulateItems();
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

        private void PopulateItems()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM  Items";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridItems.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void FilterByItemType()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM Items WHERE ItemType='" + ctrlItemType.SelectedItem.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridItems.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
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
            
            if (_FuelCount > 1 && itemPrice > 50) {
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
            Transaction newTransaction = new Transaction(
                CustomerId,                
                Convert.ToDecimal(ctrlDiscountValue.Text), 
                Convert.ToDecimal(ctrlTotalValue.Text),
                Convert.ToDecimal(ctrlTotalCost.Text)
            );

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Transaction (ID, Date, CustomerID, DiscountValue, TotalValue, TotalCost) VALUES (NEWID(), '" + newTransaction.GetDate() + "', '" + newTransaction.CustomerID + "','" + newTransaction.DiscountValue + "', '" + newTransaction.TotalValue + "', '" + newTransaction.TotalCost + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction Succesfully Added");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }

            AddTransactionLines(newTransaction);
        }

        private void AddTransactionLines(Transaction newTransaction)
        {
            foreach (var item in _TransactionLines)
            {
                item.ID = newTransaction.ID;
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TransactionLine (ID, TransactionID, ItemID, Quantity, ItemPrice, Value, ItemCost, Cost, ItemType) VALUES ('" + item.ID + "', '" + item.TransactionID + "', '" + item.ItemID + "', '" + item.Quantity + "', '" + item.ItemPrice + "', '" + item.Value + "', '" + item.ItemCost + "', '" + item.Cost + "', '" + item.ItemType + "')", Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }
        
    }
}
