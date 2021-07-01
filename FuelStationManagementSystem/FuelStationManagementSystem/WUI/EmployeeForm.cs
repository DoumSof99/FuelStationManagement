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

        #region Events
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Populate();
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();
            Populate();
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
            Controller.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
        }

        #endregion

        #region Methods
        private void AddEmployee()
        {
                              
            string emplName = Convert.ToString(ctrlName.EditValue);
            string emplSurname = Convert.ToString(ctrlSurname.EditValue);
            string emplSalary = Convert.ToString(ctrlSalary.EditValue);
            decimal salary;

            if (!string.IsNullOrWhiteSpace(emplName) && !string.IsNullOrWhiteSpace(emplSurname) && decimal.TryParse(emplSalary, out salary))
            {
                Employee newEmployee = new Employee(emplName, emplSurname, salary);
                string myquery = "INSERT INTO Employee (ID, Name, Surname, DateStart, Salary) VALUES (NEWID(), '" + newEmployee.Name + "', '" + newEmployee.Surname + "', '" + newEmployee.GetStartDate() + "', '" + newEmployee.Salary + "'";
                int rowsAffected = DatabaseProcedure(myquery);
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Employee was not Added");
                }
                else
                {
                    MessageBox.Show("Employee Succesfully Added");
                }      
            }
            else
            {
                MessageBox.Show("Please fill the correct values");
            }
        }

        private void DeleteCustomer()
        {
            try
            {
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                string myquery = "UPDATE Employee SET DateEnd='" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE Id='" + id + "'";
                int rowsAffected = DatabaseProcedure(myquery);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Employee was not Dismissed!");
                }
                else
                {
                    MessageBox.Show("Employee Successfully Dismissed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCustomer()
        {
            try
            {
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                string myquery = "UPDATE Employee SET Name='" + ctrlName.Text + "',Surname='" + ctrlSurname.Text + "',Salary='" + ctrlSalary.Text + "' WHERE ID='" + id + "'";
                int rowsAffected = DatabaseProcedure(myquery);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Employee was not Updated!");
                }
                else
                {
                    MessageBox.Show("Employee Successfully Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void ResetFields()
        //{
        //    ctrlName.Text = String.Empty;
        //    ctrlSurname.Text = String.Empty;
        //    ctrlSalary.Text = String.Empty;
        //}

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlName.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Name"));
            ctrlSurname.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Surname"));
            ctrlSalary.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Salary"));
        }

        private void Populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM Employee";
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

        private int DatabaseProcedure(string myquery)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(myquery);
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();
                Populate();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
                return 0;
            }
        }

        #endregion
    }
}
