using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationManagementSystem.Impl {
    public class Controller {

        

        public static void PopulateController(SqlConnection con, string query, DevExpress.XtraGrid.GridControl grid) {
            

            try {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                grid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
