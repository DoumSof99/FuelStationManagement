using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl
{
    public class Transaction : Entity
    {
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        public Transaction() : base()
        {
            Date = DateTime.Now;
        }
    }
}
