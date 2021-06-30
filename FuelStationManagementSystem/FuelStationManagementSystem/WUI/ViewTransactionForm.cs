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

namespace FuelStationManagementSystem.WUI {
    public partial class ViewTransactionForm : Form {

        public SqlConnection Con { get; set; }
        public Guid TransactionID { get; set; }

        public ViewTransactionForm() {
            InitializeComponent();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e) {
           
            Populate();
        }

        private void Populate() {
            try {
                Con.Open();
                string Myquery = "SELECT * FROM  [Transaction]";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridTransaction.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void gridTransaction_DoubleClick(object sender, EventArgs e) {

           
        }

        private void gridViewTransaction_DoubleClick(object sender, EventArgs e) {
            TransactionID = Guid.Parse(Convert.ToString(gridViewTransaction.GetFocusedRowCellValue("ID")));

            ViewTransactionLineForm viewTransactionLine = new ViewTransactionLineForm();
            viewTransactionLine.Con = Con;
            viewTransactionLine.TransactionID = TransactionID;
            viewTransactionLine.ShowDialog();
        }

        private void gridTransaction_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e) {
           
        }
    }
}
