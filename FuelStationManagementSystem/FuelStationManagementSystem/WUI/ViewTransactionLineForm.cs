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
            string Myquery = String.Format(Resource.QPopulateViewTransactionLine, Convert.ToString(ID));
            Utility.PopulateUtility(Con, Myquery, gridTransactionLine);
        }
    }
}
