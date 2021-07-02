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

namespace FuelStationManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        public string ConnectionString { get => ctrlConnection.Text; set => ConnectionString = value; }
        private SqlConnection _SqlConnection;


        #region Events

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddItems();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ChooseCustomer();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ViewTransaction();
        }

        private void viewToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ViewLedger();
        }

        #endregion

        #region methods

        private void AddCustomer()
        {
            CustomerForm customerForm = new CustomerForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            customerForm.Con = _SqlConnection;
            customerForm.ShowDialog();
        }

        private void AddItems()
        {
            ItemForm itemForm = new ItemForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            itemForm.Con = _SqlConnection;
            itemForm.ShowDialog();
        }

        private void AddEmployee()
        {
            EmployeeForm employeeForm = new EmployeeForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            employeeForm.Con = _SqlConnection;
            employeeForm.ShowDialog();
        }

        private void ChooseCustomer()
        {
            ChooseCustomerForm chooseCustomerForm = new ChooseCustomerForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            chooseCustomerForm.Con = _SqlConnection;
            chooseCustomerForm.ShowDialog();
        }

        private void ViewTransaction()
        {
            ViewTransactionForm viewTransaction = new ViewTransactionForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            viewTransaction.Con = _SqlConnection;
            viewTransaction.ShowDialog();
        }

        private void ViewLedger()
        {
            LedgerForm ledgerForm = new LedgerForm();
            _SqlConnection = new SqlConnection(ConnectionString);
            ledgerForm.Con = _SqlConnection;
            ledgerForm.ShowDialog();
        }

        #endregion


    }


    public class MyColorTable : ProfessionalColorTable
    {
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.Crimson;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Crimson;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Crimson;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Crimson;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Black;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.DarkRed;
            }
        }

        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.Crimson;
            }
        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.Crimson;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.DarkRed;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.DarkRed;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }
      
    }
}
