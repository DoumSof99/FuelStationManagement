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

namespace FuelStationManagementSystem.WUI
{
    public partial class CustomerForm : Form
    {

        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=FuelStationManagement;Integrated Security=True");

        public SqlConnection Con { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Controller.PopulateController(Con, Resource.QPopulateCustomer, gridCustomers);
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer();
            Populate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer(ctrlCardNumber);
        }
       
        private void AddCustomer()
        {                            
            string custName = Convert.ToString(ctrlName.EditValue);
            string custSurname = Convert.ToString(ctrlSurname.EditValue);
            string custCardNumber = Convert.ToString(ctrlCardNumber.EditValue);
            Regex cardNumber = new Regex(@"^[1-9][0-9]{15}$");

            Customer newCustomer = new Customer(custName, custSurname, custCardNumber);

            if (string.IsNullOrWhiteSpace(custName) && string.IsNullOrWhiteSpace(custSurname) && string.IsNullOrWhiteSpace(custCardNumber))
            {
                MessageBox.Show("Please fill all the fields!");
            }
            else if (!cardNumber.Match(custCardNumber).Success){
                MessageBox.Show("Invalid credit card number!");
            }
            else
            {
                string myquery = "INSERT INTO Customer (ID, Name, Surname, CardNumber) VALUES ('" + newCustomer.ID + "', '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')";
                string message = "Customer Succesfully Added";
                DatabaseProcedure(myquery);            
            }

        private void Populate()
        {

           

            //try
            //{
            //    Con.Open();
            //    string MyQuery = Resource.QPopulateCustomer;
            //    SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
            //    SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //    var ds = new DataSet();
            //    da.Fill(ds);
            //    gridCustomers.DataSource = ds.Tables[0];
            //    Con.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void DeleteCustomer()
        {                     
            string myquery = "DELETE FROM Customer WHERE CardNumber='" + ctrlCardNumber.EditValue + "'";
            int rowsAffected = DatabaseProcedure(myquery);
             
            if (rowsAffected == 0)
            {
                MessageBox.Show("Customer was not deleted!");
            } else {
                MessageBox.Show("Customer Successfully Deleted");
            }
            
        }

        private void EditCustomer()
        {
                        
            string myquery = "UPDATE Customer SET Name='" + ctrlName.EditValue + "',Surname='" + ctrlSurname.EditValue + "' WHERE CardNumber='" + ctrlCardNumber.EditValue + "'";
            int rowsAffected = DatabaseProcedure(myquery);
            if (rowsAffected == 0)
            {
                MessageBox.Show("Customer was not Updated!");
            }
            else
            {
                MessageBox.Show("Customer Successfully Updated");
            }

        }

        private void ResetFields()
        private void DeleteCustomer(DevExpress.XtraEditors.TextEdit CardNumber)
        {
            ctrlName.EditValue = String.Empty;
            ctrlSurname.EditValue = String.Empty;
            ctrlCardNumber.EditValue = String.Empty;
        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlName.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("Name"));
            ctrlSurname.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("Surname"));
            ctrlCardNumber.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("CardNumber"));
        }

        private void Populate()
        {
            try
            if (CardNumber.Text == String.Empty)
            {
                MessageBox.Show("Enter the Customer's Card Number");
            }
            else
            {
                Con.Open();
                string MyQuery = "SELECT * FROM Customer";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridCustomers.DataSource = ds.Tables[0];
                string cardNum = Convert.ToString(CardNumber.EditValue);
                string myquery = Resource.QDeleteCusomer + String.Format("'{0}'", cardNum);  //"DELETE FROM Customer WHERE CardNumber='" + ctrlCardNumber.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int DatabaseProcedure(string myquery)

        private void EditCustomer()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(myquery, Con);
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();
                Populate();
                ResetFields();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                Con.Close();
                return 0;
            }
        }
    }
}
