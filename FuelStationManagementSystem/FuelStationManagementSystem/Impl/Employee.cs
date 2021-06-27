using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl
{
    public class Employee : Person
    {
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, decimal salary) :  base()
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            DateStart = DateTime.Now;
            DateEnd = null;
        }

        public string GetStartDate()
        {
            string startDate = DateStart.ToString("yyyy-MM-dd");
            return startDate;
        }
    }
}
