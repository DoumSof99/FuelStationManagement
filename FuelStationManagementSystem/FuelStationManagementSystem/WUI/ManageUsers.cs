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

namespace FuelStationManagementSystem
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EYA\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            Populate();
            ResetFields();
        }

        private void ctrlUserName_Enter(object sender, EventArgs e)
        {
            sptUserName.LineColor = Color.BlueViolet;
        }

        private void ctrlUserName_Leave(object sender, EventArgs e)
        {
            sptUserName.LineColor = Color.DarkViolet;
        }

        private void ctrlFullName_Enter(object sender, EventArgs e)
        {
            sptFullName.LineColor = Color.BlueViolet;
        }

        private void ctrlFullName_Leave(object sender, EventArgs e)
        {
            sptFullName.LineColor = Color.DarkViolet;
        }

        private void ctrlPassword_Enter(object sender, EventArgs e)
        {
            sptPassword.LineColor = Color.BlueViolet;
        }

        private void ctrlPassword_Leave(object sender, EventArgs e)
        {
            sptPassword.LineColor = Color.DarkViolet;
        }
        private void ctrlTelephone_Enter(object sender, EventArgs e)
        {
            sptTelephone.LineColor = Color.BlueViolet;
        }

        private void ctrlTelephone_Leave(object sender, EventArgs e)
        {
            sptTelephone.LineColor = Color.DarkViolet;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTb values('" + ctrlUserName.Text + "', '" + ctrlFullName.Text + "', '" + ctrlPassword.Text + "', '" + ctrlTelephone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ctrlUsers.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ctrlTelephone.Text == "Telephone")
            {
                MessageBox.Show("Enter the User's Phone Number");
            } else
            {
                Con.Open();
                string myquery = "delete from UserTb where Uphone='" + ctrlTelephone.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                Populate();
                ResetFields();
            }
        }

        private void gridViewUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlUserName.Text = gridViewUsers.GetFocusedRowCellValue("Uname").ToString();
            ctrlFullName.Text = gridViewUsers.GetFocusedRowCellValue("Ufullname").ToString();
            ctrlPassword.Text = gridViewUsers.GetFocusedRowCellValue("Upassword").ToString();
            ctrlTelephone.Text = gridViewUsers.GetFocusedRowCellValue("Uphone").ToString();
        }

        private void ResetFields()
        {
            ctrlUserName.Text = "UserName";
            ctrlFullName.Text = "FullName";
            ctrlPassword.Text = "Password";
            ctrlTelephone.Text = "Telephone";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTb set Uname='" + ctrlUserName.Text + "',Ufullname='" + ctrlFullName.Text + "',Upassword='" + ctrlPassword.Text + "' where Uphone='" + ctrlTelephone.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                Populate();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
