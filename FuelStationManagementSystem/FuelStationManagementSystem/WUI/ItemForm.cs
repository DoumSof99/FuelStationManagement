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

namespace FuelStationManagementSystem.WUI {
    public partial class ItemForm : Form {

        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=FuelStationManagement;Integrated Security=True");

        public SqlConnection Con { get; set; }

        public ItemForm() {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e) {
            Populate();
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddItem();
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            EditItem();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteItem();
        }

        private void Populate() {
            Con.Open();
            string MyQuery = "SELECT ID, Code, Description, ItemType, Price, Cost FROM Items";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gridItems.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ResetFields() {
            ctrlCode.Text = String.Empty;
            ctrlDescription.Text = String.Empty;
            ctrlItemType.Text = String.Empty;
            ctrlPrice.Text = String.Empty;
            ctrlCost.Text = String.Empty;
        }

        private void AddItem() {
            string code = Convert.ToString(ctrlCode.Text);
            string descreption = Convert.ToString(ctrlDescription.Text);
            string itemType = Convert.ToString(ctrlItemType.SelectedItem.ToString());
            decimal price = Convert.ToDecimal(ctrlPrice.Text);
            decimal cost = Convert.ToDecimal(ctrlCost.Text);

           // Item newItem = new Item(code, descreption, itemType, price, cost);

            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Items (ID, Code, Description, ItemType, Price, Cost) VALUES (NEWID(), '" + code + "', '" + descreption + "', '" + itemType + "', '" + price + "', '" + cost + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Items Succesfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception) {

                MessageBox.Show("Please enter all values");
            }
        }

        private void EditItem() {
            try {
                Guid id = Guid.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("ID")));
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Items SET Code ='" + ctrlCode.Text + "', Description='" + ctrlDescription.Text + "', ItemType ='" + ctrlItemType.SelectedItem.ToString() + "', Price = '" + ctrlPrice.Text + "', Cost = '" + ctrlCost.Text + "' WHERE ID ='" + id + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                Populate();
                ResetFields();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            ctrlCode.Text = Convert.ToString(gridViewItems.GetFocusedRowCellValue("Code"));
            ctrlDescription.Text = Convert.ToString(gridViewItems.GetFocusedRowCellValue("Description"));
            ctrlItemType.Text = Convert.ToString(gridViewItems.GetFocusedRowCellValue("ItemType"));
            ctrlPrice.Text = Convert.ToString(gridViewItems.GetFocusedRowCellValue("Price"));
            ctrlCost.Text = Convert.ToString(gridViewItems.GetFocusedRowCellValue("Cost"));
        }

        private void DeleteItem() {
            if (ctrlCode.Text == String.Empty) {
                MessageBox.Show("Select a field");
            }
            else {
                Guid id = Guid.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("ID")));

                Con.Open();
                string myquery = "DELETE FROM Items WHERE ID='" + id + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Deleted");
                Con.Close();
                Populate();
                ResetFields();
            }
        }
        
    }
}
