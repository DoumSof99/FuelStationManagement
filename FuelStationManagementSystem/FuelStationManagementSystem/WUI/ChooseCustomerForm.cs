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
    public partial class ChooseCustomerForm : Form
    {
        public ChooseCustomerForm()
        {
            InitializeComponent();
        }

        public SqlConnection Con { get; set; }
        public Guid CustomerId { get; set; }

        private void ChooseCustomerForm_Load(object sender, EventArgs e)
        {
            FillCustomerCard();
        }

        private void ctrlCardNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try {
                string Myquery = String.Format(Resource.QFindCustomer, Convert.ToString(ctrlCardNumber.SelectedValue));
                Utility.PopulateUtility(Con, Myquery, gridCustomers);
                CustomerId = Guid.Parse(Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("ID")));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }

        private void FillCustomerCard()
        {

            string query = Resource.QFillCustomerCard;
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CardNumber", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                ctrlCardNumber.ValueMember = "CardNumber";
                ctrlCardNumber.DataSource = dt;
                ctrlCardNumber.SelectedIndex = -1;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void AddTransaction()
        {
            if (ctrlCardNumber.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Card Number");
            } else
            {
                TransactionForm transactionForm = new TransactionForm();
                transactionForm.Con = Con;
                transactionForm.CustomerId = CustomerId;
                transactionForm.ShowDialog();
            }        
        }

        
    }
}
