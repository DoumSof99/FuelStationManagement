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
            Utility.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);
            Utility.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddCustomer();
            Utility.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);
            
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            EditCustomer();
            Utility.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);
            
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            DeleteCustomer(ctrlCardNumber);
            Utility.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);          
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
                //string myquery = "INSERT INTO Customer (ID, Name, Surname, CardNumber) VALUES ('" + newCustomer.ID + "', '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')";
                string myquery = String.Format(Resource.QAddCustomer, newCustomer.Name, newCustomer.Surname, newCustomer.CardNumber, newCustomer.ID);
                Utility.DatabaseProcedure(Con, myquery, gridCustomers);
                MessageBox.Show("Customer Succesfully Added");
                Utility.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
            }
        }

        private void DeleteCustomer(DevExpress.XtraEditors.TextEdit cardNumber) {
            string cardNum = Convert.ToString(cardNumber.EditValue);
            string myquery = String.Format(Resource.QDeleteCustomer, cardNum);
            int rowsAffected = Utility.DatabaseProcedure(Con, myquery, gridCustomers);

            if (rowsAffected == 0) {
                MessageBox.Show("Customer was not deleted!");
            }
            else {
                MessageBox.Show("Customer Successfully Deleted");
                Utility.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
            }

        }

        private void EditCustomer() {

            string myquery = String.Format(Resource.QEditCustomer, Convert.ToString(ctrlName.EditValue), Convert.ToString(ctrlSurname.EditValue), Convert.ToString(ctrlCardNumber.EditValue));  //"UPDATE Customer SET Name='" + ctrlName.EditValue + "',Surname='" + ctrlSurname.EditValue + "' WHERE CardNumber='" + ctrlCardNumber.EditValue + "'";
            int rowsAffected = Utility.DatabaseProcedure(Con, myquery, gridCustomers);
            if (rowsAffected == 0) {
                MessageBox.Show("Customer was not Updated!");
            }
            else {
                MessageBox.Show("Customer Successfully Updated");
                Utility.ResetFields(ctrlName, ctrlSurname, ctrlCardNumber);
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
