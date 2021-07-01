using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationManagementSystem.Impl {
    public class Utility {

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

        //
        public static int DatabaseProcedure(SqlConnection con, string query, DevExpress.XtraGrid.GridControl grid) {
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                //Controller.PopulateController(con, Resource.QPopulateCustomer, grid);
                return rowsAffected;
            }
            catch (Exception ex) {
                con.Close();
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        //RESET FIELDS
        public static void ResetFields(DevExpress.XtraEditors.TextEdit value1, DevExpress.XtraEditors.TextEdit value2, DevExpress.XtraEditors.TextEdit value3) {
            value1.EditValue = String.Empty;
            value2.EditValue = String.Empty;
            value3.EditValue = String.Empty;
        }

    }
}
