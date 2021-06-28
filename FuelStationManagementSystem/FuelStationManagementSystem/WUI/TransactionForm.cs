using DevExpress.XtraGrid;
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

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            FillCustomerCard();
            PopulateItems();
        }
        private void ctrlItemType_SelectedValueChanged(object sender, EventArgs e) {
            FilterByItemType();

        }
         private void ctrlCardNumber_SelectionChangeCommitted(object sender, EventArgs e) {
             PopulateCustomers();
         }
        private void btnRefresh_Click(object sender, EventArgs e) {
            PopulateItems();
        }
        private void btnAddItem_Click(object sender, EventArgs e) {
            AddItems();
        }
        private void PopulateCustomers()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM  Customer WHERE CardNumber = '" + Convert.ToString(ctrlCardNumber.SelectedValue) + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridCustomers.DataSource = ds.Tables[0];
                Con.Close();

                Guid id = Guid.Parse(Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("ID")));

                ctrlCustomerID.Text = Convert.ToString(id);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }


        private void PopulateItems()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from  Items";
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
                string Myquery = "select * from  Items where ItemType='" + ctrlItemType.SelectedItem.ToString() + "'";
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

        private void FillCustomerCard() {
            
            string query = "select CardNumber from Customer";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CardNumber", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                ctrlCardNumber.ValueMember = "CardNumber";
                ctrlCardNumber.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        DataTable table = new DataTable() {
            Columns = { { "ItemID" }, { "Quantity" }, { "ItemPrice" }, { "Value" }, { "ItemCost" }, { "Cost" } }
        };

     //   bool fuelAdded = false;
        int fuelCount = 0;
        private void AddItems() {
          
            string itemType = Convert.ToString(gridViewItems.GetFocusedRowCellValue("ItemType"));
           
            Guid itemID = Guid.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("ID")));
            int itemQuantity = Convert.ToInt32(ctrlQuantity.Text);
            decimal itemPrice = decimal.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("Price")));
            decimal itemCost = decimal.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("Cost")));
            decimal value = itemQuantity * itemPrice;
            decimal cost = itemQuantity * itemCost;
            
            if (itemType == "Fuel") {
             //   fuelAdded = true;
                fuelCount += 1;
                itemQuantity = 1;
            }

            if (fuelCount > 1) {
                MessageBox.Show("You have already chosen Fuel!");
            }
            else {
                table.Rows.Add(itemID, itemQuantity, itemPrice, value, itemCost, cost);
                gridTransactionLines.DataSource = table;

                GridSummaryItem totalValue = gridViewTransactionLines.Columns["Value"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Value", "Sum = {0:N2}");
                ctrlTotalValue.Text = Convert.ToString(totalValue.SummaryValue);

                GridSummaryItem totalCost = gridViewTransactionLines.Columns["Cost"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "Cost", "Sum = {0:N2}");
                ctrlTotalCost.Text = Convert.ToString(totalCost.SummaryValue);

            }

            

        }
    }
}
