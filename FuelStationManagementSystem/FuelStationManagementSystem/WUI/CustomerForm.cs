using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FuelStationManagementSystem.Impl;
using DevExpress.XtraGrid;
using System.Text.RegularExpressions;

namespace FuelStationManagementSystem.WUI {
    public partial class CustomerForm : Form {

        public SqlConnection Con { get; set; }

        public CustomerForm() {
            InitializeComponent();
        }

        #region Events

        private void CustomerForm_Load(object sender, EventArgs e) {
            Controller.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddCustomer();
            Controller.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            EditCustomer();
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteCustomer(ctrlCardNumber);
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
        }

        #endregion

        #region Methods

        private void AddCustomer() {
            string custName = Convert.ToString(ctrlName.EditValue);
            string custSurname = Convert.ToString(ctrlSurname.EditValue);
            string custCardNumber = Convert.ToString(ctrlCardNumber.EditValue);

            Regex cardNumber = new Regex(@"^[1-9][0-9]{15}$");

            Customer newCustomer = new Customer(custName, custSurname, custCardNumber);

            if (string.IsNullOrWhiteSpace(custName) && string.IsNullOrWhiteSpace(custSurname) && string.IsNullOrWhiteSpace(custCardNumber)) {
                MessageBox.Show("Please fill all the fields!");
            }
            else if (!cardNumber.Match(custCardNumber).Success) {
                MessageBox.Show("Invalid credit card number!");
            }
            else {
                string myquery = "INSERT INTO Customer (ID, Name, Surname, CardNumber) VALUES ('" + newCustomer.ID + "', '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')";
                Controller.DatabaseProcedure(Con, myquery, gridCustomers);
                MessageBox.Show("Customer Succesfully Added");
            }
        }

        private void DeleteCustomer(DevExpress.XtraEditors.TextEdit cardNumber) {
            string cardNum = Convert.ToString(cardNumber.EditValue);
            string myquery = Resource.QDeleteCusomer + String.Format("'{0}'", cardNum);
            int rowsAffected = Controller.DatabaseProcedure(Con, myquery, gridCustomers);

            if (rowsAffected == 0) {
                MessageBox.Show("Customer was not deleted!");
            }
            else {
                MessageBox.Show("Customer Successfully Deleted");
            }

        }

        private void EditCustomer() {

            string myquery = "UPDATE Customer SET Name='" + ctrlName.EditValue + "',Surname='" + ctrlSurname.EditValue + "' WHERE CardNumber='" + ctrlCardNumber.EditValue + "'";
            int rowsAffected = Controller.DatabaseProcedure(Con, myquery, gridCustomers);
            if (rowsAffected == 0) {
                MessageBox.Show("Customer was not Updated!");
            }
            else {
                MessageBox.Show("Customer Successfully Updated");
            }

        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            ctrlName.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("Name"));
            ctrlSurname.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("Surname"));
            ctrlCardNumber.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("CardNumber"));
        }

       
        #endregion
    } 
}
