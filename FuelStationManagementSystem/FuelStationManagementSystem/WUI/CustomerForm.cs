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

namespace FuelStationManagementSystem.WUI
{
    public partial class CustomerForm : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=FuelStationManagement;Integrated Security=True");

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddCustomer();

        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }

        private void AddCustomer() {
            //if (!string.IsNullOrWhiteSpace(ctrlName.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlSurname.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlCardNumber.Text)){
            string custName = Convert.ToString(ctrlName.Text);
            string custSurname = Convert.ToString(ctrlSurname.Text);
            int custCardNumber = Convert.ToInt32(ctrlCardNumber.Text);


            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (ID, Name, Surname, CardNumber) VALUES (NEWID(), '" + custName + "', '" + custSurname + "', '" + custCardNumber + "')", Con);
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
