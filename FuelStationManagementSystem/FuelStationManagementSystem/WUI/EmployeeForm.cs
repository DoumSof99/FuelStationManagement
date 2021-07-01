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

        public SqlConnection Con { get; set; }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        #region Events
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            Utility.PopulateUtility(Con, Resource.QPopulateEmployee, gridEmployees);
            Utility.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee();
            Utility.PopulateUtility(Con, Resource.QPopulateEmployee, gridEmployees);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditEmployee();
            Utility.PopulateUtility(Con, Resource.QPopulateEmployee, gridEmployees);
            
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            DismissEmployee();
            Utility.PopulateUtility(Con, Resource.QPopulateEmployee, gridEmployees);
            Utility.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteEmployee();
            Utility.PopulateUtility(Con, Resource.QPopulateEmployee, gridEmployees);         
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
                //string myquery = "INSERT INTO Employee (ID, Name, Surname, DateStart, Salary) VALUES (NEWID(), '" + newEmployee.Name + "', '" + newEmployee.Surname + "', '" + newEmployee.GetStartDate() + "', '" + newEmployee.Salary + "'";
                string myquery = String.Format(Resource.QAddEmployee, newEmployee.Name, newEmployee.Surname, newEmployee.GetStartDate(), newEmployee.Salary);
                int rowsAffected = Utility.DatabaseProcedure(Con, myquery, gridEmployees);
                if (rowsAffected == 0)
                {
                    MessageBox.Show("Employee was not Added");
                }
                else
                {
                    MessageBox.Show("Employee Succesfully Added");
                    Utility.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
                }      
            }
            else
            {
                MessageBox.Show("Please fill the correct values");
            }
        }

        private void DismissEmployee()
        {
            try
            {
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                //string myquery = "UPDATE Employee SET DateEnd='" + DateTime.Now.ToString("yyyy-MM-dd") + "' WHERE ID='" + id + "'";
                string myquery = String.Format(Resource.QDismissEmployee, DateTime.Now.ToString("yyyy-MM-dd"), id);
                int rowsAffected = Utility.DatabaseProcedure(Con, myquery, gridEmployees);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Employee was not Dismissed!");
                }
                else
                {
                    MessageBox.Show("Employee Successfully Dismissed");
                    Utility.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteEmployee()
        {
            try
            {
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                string myquery = String.Format(Resource.QDeleteEmployee, id);
                int rowsAffected = Utility.DatabaseProcedure(Con, myquery, gridEmployees);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Employee was not Deleted!");
                }
                else
                {
                    MessageBox.Show("Employee Successfully Deleted");
                    Utility.ResetFields(ctrlName, ctrlSurname, ctrlSalary);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditEmployee()
        {
            try 
            { 
            
                Guid id = Guid.Parse(Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("ID")));
                //string myquery = "UPDATE Employee SET Name='" + ctrlName.Text + "',Surname='" + ctrlSurname.Text + "',Salary='" + ctrlSalary.Text + "' WHERE ID='" + id + "'";
                string myquery = String.Format(Resource.QEditEmployee, Convert.ToString(ctrlName.EditValue), Convert.ToString(ctrlSurname.EditValue), Convert.ToDecimal(ctrlSalary.EditValue.ToString()), id);
                int rowsAffected = Utility.DatabaseProcedure(Con, myquery, gridEmployees);

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

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlName.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Name"));
            ctrlSurname.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Surname"));
            ctrlSalary.Text = Convert.ToString(gridViewEmployees.GetFocusedRowCellValue("Salary"));
        }

        #endregion

        
    }
}
