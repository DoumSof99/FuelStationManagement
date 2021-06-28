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

        #endregion

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void AddEmployee()
        {
            EmployeeForm employeeForm = new EmployeeForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            employeeForm.Con = _SqlConnection;
            employeeForm.ShowDialog();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            transactionForm.Con = _SqlConnection;
            transactionForm.ShowDialog();
        }
    }
}
