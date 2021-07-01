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
            Utility.PopulateUtility(Con, Resource.QPopulateItem, gridItems);
            Utility.ResetFields(ctrlCode, ctrlDescription, ctrlItemType, ctrlPrice, ctrlCost);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddItem();
            Utility.PopulateUtility(Con, Resource.QPopulateItem, gridItems);
        }
        private void btnEdit_Click(object sender, EventArgs e) {
            EditItem();
            Utility.PopulateUtility(Con, Resource.QPopulateItem, gridItems);
            Utility.ResetFields(ctrlCode, ctrlDescription, ctrlItemType, ctrlPrice, ctrlCost);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteItem();
            Utility.PopulateUtility(Con, Resource.QPopulateItem, gridItems);
            Utility.ResetFields(ctrlCode, ctrlDescription, ctrlItemType, ctrlPrice, ctrlCost);
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
                string MyQuery = String.Format(Resource.QAddItem, code, descreption, itemType, price, cost);
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Items Succesfully Added");
                Con.Close();
               
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void EditItem() {
            try {
                Guid id = Guid.Parse(Convert.ToString(gridViewItems.GetFocusedRowCellValue("ID")));
                Con.Open();
                string MyQuery = String.Format(Resource.QEditItems, ctrlCode.Text, ctrlDescription.Text, ctrlItemType.SelectedItem.ToString(), ctrlPrice.Text, ctrlCost.Text, id);
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
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
                string myquery = String.Format(Resource.QDeleteItems, id);
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Deleted");
                Con.Close();
                
            }
        }
        
    }
}
