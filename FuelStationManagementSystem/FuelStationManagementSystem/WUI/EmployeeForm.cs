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
using FuelStationManagementSystem.Impl;

namespace FuelStationManagementSystem.WUI
{
    public partial class EmployeeForm : Form
    {

        //SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=FuelStationManagement;Integrated Security=True");

        public SqlConnection Con { get; set; }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Populate();
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();
            Populate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void Populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT ID, Name, Surname, DateStart, DateEnd, Salary FROM Employee";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridEmployees.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddEmployee()
        {
            //if (!string.IsNullOrWhiteSpace(ctrlName.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlSurname.Text.ToString()) || !string.IsNullOrWhiteSpace(ctrlCardNumber.Text)){                    
            string emplName = Convert.ToString(ctrlName.Text);
            string emplSurname = Convert.ToString(ctrlSurname.Text);
            decimal emplSalary = Convert.ToDecimal(ctrlSalary.Text);


            Employee newEmployee = new Employee(emplName, emplSurname, emplSalary);

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee (ID, Name, Surname, DateStart, Salary) VALUES (NEWID(), '" + newEmployee.Name + "', '" + newEmployee.Surname + "', '" + newEmployee.GetStartDate() + "', '" + newEmployee.Salary + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Succesfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //}
            //else {
            //    MessageBox.Show("Please add all the values correctly");
            //}
        }

        private void DeleteCustomer()
        {
            if (ctrlName.Text == String.Empty)
            {
                MessageBox.Show("Select an employee");
            }
            else
            {             
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                
                Con.Open();
                //string myquery = "DELETE FROM Employee WHERE Id='" + id + "'";
                string myquery = "UPDATE Employee SET DateEnd='" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Dismissed");
                Con.Close();
                Populate();
                ResetFields();
            }
        }

        private void EditCustomer()
        {
            try
            {
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name='" + ctrlName.Text + "',Surname='" + ctrlSurname.Text + "',Salary='" + ctrlSalary.Text + "' WHERE ID='" + id + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Updated");
                Con.Close();
                Populate();
                ResetFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields()
        {
            ctrlName.Text = String.Empty;
            ctrlSurname.Text = String.Empty;
            ctrlSalary.Text = String.Empty;
        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlName.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Name"));
            ctrlSurname.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Surname"));
            ctrlSalary.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Salary"));
        }

        
    }
}
