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

namespace FuelStationManagementSystem.WUI {
    public partial class ViewTransactionForm : Form {

        public SqlConnection Con { get; set; }
        public Guid Id { get; set; }

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
