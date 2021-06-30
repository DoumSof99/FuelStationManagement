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

namespace FuelStationManagementSystem.WUI {
    public partial class ViewTransactionLineForm : Form {

        public SqlConnection Con { get; set; }
        public Guid ID { get; set; }

        public ViewTransactionLineForm() {
            InitializeComponent();
        }

        private void ViewTransactionLineForm_Load(object sender, EventArgs e) {
            PopulateTransactionLine();
        }

        private void PopulateTransactionLine() {
            try {

                string transactionId = Convert.ToString(ID);
                          
                Con.Open();
                string Myquery = "SELECT * FROM TransactionLine WHERE TransactionID = '" + transactionId + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridTransactionLine.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void gridTransactionLine_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e) {

        }
    }
}
