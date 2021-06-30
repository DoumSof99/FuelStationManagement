using DevExpress.XtraGrid.Columns;
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
    public partial class LedgerForm : Form {

        public SqlConnection Con { get; set; }
        private const decimal rent = 5000m;

        public LedgerForm() {
            InitializeComponent();
        }

        private void LedgerForm_Load(object sender, EventArgs e) {
         
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddDates();
        }

        private void AddDates() {

            DateTime dateFrom = Convert.ToDateTime(ctrlDateFrom.EditValue);
            DateTime dateTo = Convert.ToDateTime(ctrlDateTo.EditValue);

            try {
                Con.Open();
                string queryIncome = "SELECT SUM(DiscountValue) AS 'Income' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
                SqlCommand cmdIncome = new SqlCommand(queryIncome, Con);
                string income = cmdIncome.ExecuteScalar().ToString();

                string queryExpensesCost = "SELECT SUM(TotalCost) AS 'ExpensesCost' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
                SqlCommand cmd = new SqlCommand(queryExpensesCost, Con);
                string expensesCost = cmd.ExecuteScalar().ToString();

                //string queryExpensesCost = "SELECT SUM(TotalCost) AS 'ExpensesCost' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
                //SqlCommand cmd = new SqlCommand(queryExpensesCost, Con);
                //string expensesCost = cmd.ExecuteScalar().ToString();

                Con.Close();

                ctrlIncome.EditValue = income;


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

      
    }
}
