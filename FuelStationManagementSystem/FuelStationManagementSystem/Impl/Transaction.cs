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
        public decimal TotalCost { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction(Guid customerId, decimal discountValue, decimal totalValue, decimal totalCost) 
            : base()
        {
            Date = DateTime.Now;
            CustomerID = customerId;
            DiscountValue = discountValue;
            TotalValue = totalValue;
            TotalCost = totalCost;    
        }

        public string GetDate()
        {
            string date = Date.ToString("yyyy-MM-dd");
            return date;
        }
    }
}
