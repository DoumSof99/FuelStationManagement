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
using DevExpress.Utils;
using FuelStationManagementSystem.Impl;

namespace FuelStationManagementSystem.WUI {
    public partial class ViewTransactionForm : Form {

        public SqlConnection Con { get; set; }
        public Guid Id { get; set; }

        public ViewTransactionForm() {
            InitializeComponent();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e) {
            Utility.PopulateUtility(Con, Resource.QViewTransaction, gridTransaction);
        }

        private void gridViewTransaction_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            ctrlCustomerID.EditValue = Convert.ToString(gridViewTransaction.GetFocusedRowCellValue("CustomerID"));
        }

        private void btnShowTransactionLine_Click(object sender, EventArgs e) {
            Id = Guid.Parse(Convert.ToString(gridViewTransaction.GetFocusedRowCellValue("ID")));

            ViewTransactionLineForm viewTransactionLine = new ViewTransactionLineForm();
            viewTransactionLine.Con = Con;
            viewTransactionLine.ID = Id;
            viewTransactionLine.ShowDialog();
        }
    }
}
