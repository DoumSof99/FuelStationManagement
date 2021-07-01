using FuelStationManagementSystem.WUI;
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

namespace FuelStationManagementSystem {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        public string ConnectionString { get => ctrlConnection.Text; set => ConnectionString = value; }
        private SqlConnection _SqlConnection;


        #region Events

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            AddCustomer();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e) {
            AddItems();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e) {
            AddEmployee();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e) {
            ChooseCustomer();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e) {
            ViewTransaction();
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e) {
            ViewLedger();
        }

        #endregion

        #region methods

        private void AddCustomer() {
            CustomerForm customerForm = new CustomerForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            customerForm.Con = _SqlConnection;
            customerForm.ShowDialog();
        }

        private void AddItems() {
            ItemForm itemForm = new ItemForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            itemForm.Con = _SqlConnection;
            itemForm.ShowDialog();
        }

        private void AddEmployee() {
            EmployeeForm employeeForm = new EmployeeForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            employeeForm.Con = _SqlConnection;
            employeeForm.ShowDialog();
        }

        private void ChooseCustomer() {
            ChooseCustomerForm chooseCustomerForm = new ChooseCustomerForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            chooseCustomerForm.Con = _SqlConnection;
            chooseCustomerForm.ShowDialog();
        }

        private void ViewTransaction() {
            ViewTransactionForm viewTransaction = new ViewTransactionForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            viewTransaction.Con = _SqlConnection;
            viewTransaction.ShowDialog();
        }

        private void ViewLedger() {
            LedgerForm ledgerForm = new LedgerForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            ledgerForm.Con = _SqlConnection;
            ledgerForm.ShowDialog();
        }
             
        #endregion
    }
}
