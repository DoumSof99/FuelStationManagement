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

        private void CustomerForm_Load(object sender, EventArgs e) {       
            Populate();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddCustomer();
            Populate();
        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void Populate() {
            try {
                Con.Open();
                string MyQuery = "SELECT Name, Surname, CardNumber FROM Customer";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridControl.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddCustomer() {
            //if (!string.IsNullOrWhiteSpace(ctrlName.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlSurname.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlCardNumber.Text)){                    
            string custName = Convert.ToString(ctrlName.Text);
            string custSurname = Convert.ToString(ctrlSurname.Text);
            string custCardNumber = Convert.ToString(ctrlCardNumber.Text);


            Customer newCustomer = new Customer(custName, custSurname, custCardNumber);

            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (ID, Name, Surname, CardNumber) VALUES (NEWID(), '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Added");
                Con.Close();
            }
            catch (Exception) {

                MessageBox.Show("Please enter all values");
            }
            //}
            //else {
            //    MessageBox.Show("Please add all the values correctly");
            //}
        }

       
    }
}
