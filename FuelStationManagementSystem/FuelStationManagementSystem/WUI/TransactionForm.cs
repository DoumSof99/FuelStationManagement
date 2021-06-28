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
            PopulateCustomers();
            PopulateItems();
        }

        private void PopulateCustomers()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from  Customer";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridCustomers.DataSource = ds.Tables[0];
                Con.Close();
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

        private void FilterByCategory()
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

        private void ctrlItemType_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterByCategory();

        }
    }
}
