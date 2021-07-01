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
            const decimal rent = 5000m;
            decimal totalRent = (dateTo - dateFrom).Days * rent / 30;

            try
            {            
                string queryIncome = "SELECT SUM(DiscountValue) AS 'Income' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom.ToString("yyyy-MM-dd") + "' AND '" + dateTo.ToString("yyyy-MM-dd") + "'";
                decimal income = GetFromDatabase(queryIncome);

                string queryCost = "SELECT SUM(TotalCost) AS 'ExpensesCost' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom.ToString("yyyy-MM-dd") + "' AND '" + dateTo.ToString("yyyy-MM-dd") + "'";
                decimal itemsCost = GetFromDatabase(queryCost);

                string queryPay = String.Format(Resource.QLedgerPay, dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"));
                decimal employeesPay = GetFromDatabase(queryPay);

                decimal expenses = employeesPay + itemsCost + totalRent;
                ctrlIncome.EditValue = income;
                ctrlExpenses.EditValue = expenses;

                CalculateTotal(income, expenses);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void CalculateTotal(decimal income, decimal expenses)
        {
            decimal total;
            if (income > expenses)
            {
                total = income - expenses;
                ctrlTotal.EditValue = Convert.ToString(total);
                lblTotal.Text = "Total Profit:";
            }
            else
            {
                total = expenses - income;
                ctrlTotal.Text = Convert.ToString(total);
                lblTotal.Text = "Total Loss:";
            }
        }


        private decimal GetFromDatabase(string myquery)
        {
            try
            {
                Con.Open();
                SqlCommand cmd= new SqlCommand(myquery, Con);
                string result = Convert.ToString(cmd.ExecuteScalar());          
                Con.Close();
                return Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
                return 0;
            }
        }
      
    }
}
