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

        private void AddCustomer()
        {
            //if (!string.IsNullOrWhiteSpace(ctrlName.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlSurname.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlCardNumber.Text)){                    
            string custName = Convert.ToString(ctrlName.Text);
            string custSurname = Convert.ToString(ctrlSurname.Text);
            string custCardNumber = Convert.ToString(ctrlCardNumber.Text);


            Customer newCustomer = new Customer(custName, custSurname, custCardNumber);

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer (ID, Name, Surname, CardNumber) VALUES (NEWID(), '" + newCustomer.Name + "', '" + newCustomer.Surname + "', '" + newCustomer.CardNumber + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
            //}
            //else {
            //    MessageBox.Show("Please add all the values correctly");
            //}
        }

        private void DeleteCustomer(DevExpress.XtraEditors.TextEdit CardNumber)
        {
            if (CardNumber.Text == String.Empty)
            {
                MessageBox.Show("Enter the Customer's Card Number");
            }
            else
            {
                Con.Open();
                string cardNum = Convert.ToString(CardNumber.EditValue);
                string myquery = Resource.QDeleteCusomer + String.Format("'{0}'", cardNum);  //"DELETE FROM Customer WHERE CardNumber='" + ctrlCardNumber.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                Populate();
                ResetFields();
            }
        }


        private void EditCustomer()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET Name='" + ctrlName.Text + "',Surname='" + ctrlSurname.Text + "' WHERE CardNumber='" + ctrlCardNumber.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                Populate();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void ResetFields()
        {
            ctrlName.Text = String.Empty;
            ctrlSurname.Text = String.Empty;
            ctrlCardNumber.Text = String.Empty;
        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlName.Text = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("Name"));
            ctrlSurname.Text = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("Surname"));
            ctrlCardNumber.Text = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("CardNumber"));
        }
    }
}
