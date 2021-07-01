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
                Con.Open();
                string queryIncome = "SELECT SUM(DiscountValue) AS 'Income' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom.ToString("yyyy-MM-dd") + "' AND '" + dateTo.ToString("yyyy-MM-dd") + "'";
                SqlCommand cmdIncome = new SqlCommand(queryIncome, Con);
                string income = Convert.ToString(cmdIncome.ExecuteScalar());


                string queryExpensesCost = "SELECT SUM(TotalCost) AS 'ExpensesCost' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom.ToString("yyyy-MM-dd") + "' AND '" + dateTo.ToString("yyyy-MM-dd") + "'";
                SqlCommand cmdExpensesCost = new SqlCommand(queryExpensesCost, Con);
                string itemsCost = Convert.ToString(cmdExpensesCost.ExecuteScalar());


                //string queryExpensesCost = "SELECT SUM(TotalCost) AS 'ExpensesCost' FROM [Transaction] WHERE [Date] BETWEEN '" + dateFrom + "' AND '" + dateTo + "'";
                //SqlCommand cmd = new SqlCommand(queryExpensesCost, Con);
                //string expensesCost = cmd.ExecuteScalar().ToString();

                string queryEmployeess = $@"SELECT Sum(Pay) FROM( SELECT *,
                CASE WHEN DateStart < {dateFrom.ToString("yyyy-MM-dd")} AND(DateEnd > {dateTo.ToString("yyyy-MM-dd")} OR DateEnd IS NULL) THEN(Salary / 25) * DATEDIFF(day, {dateFrom.ToString("yyyy-MM-dd")}, {dateTo.ToString("yyyy-MM-dd")})
                WHEN DateStart >= {dateFrom.ToString("yyyy-MM-dd")} AND(DateEnd > {dateTo.ToString("yyyy-MM-dd")} OR DateEnd IS NULL) THEN(Salary / 25) * DATEDIFF(day, DateStart, {dateTo.ToString("yyyy-MM-dd")})
                WHEN DateStart < {dateFrom.ToString("yyyy-MM-dd")} AND DateEnd <= {dateTo.ToString("yyyy-MM-dd")} THEN(Salary / 25) * DATEDIFF(day, {dateFrom.ToString("yyyy-MM-dd")}, DateEnd)
                WHEN DateStart >= {dateFrom.ToString("yyyy-MM-dd")} AND DateEnd <= {dateTo.ToString("yyyy-MM-dd")} THEN(Salary / 25) * DATEDIFF(day, DateStart, DateEnd)
                END AS Pay FROM(SELECT * FROM Employee WHERE DateStart <= {dateTo.ToString("yyyy-MM-dd")} AND DateEnd >= {dateFrom.ToString("yyyy-MM-dd")}) As Employees) As Pay";
                SqlCommand cmdEmployees = new SqlCommand(queryEmployeess, Con);
                string employeesPay = Convert.ToString(cmdExpensesCost.ExecuteScalar());

                Con.Close();

                ctrlIncome.EditValue = income;
                ctrlExpenses.EditValue = employeesPay + itemsCost + totalRent;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

      
    }
}
