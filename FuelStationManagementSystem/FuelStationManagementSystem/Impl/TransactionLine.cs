using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl {
    public class TransactionLine : Entity {

        public Guid TransactionID { get; set; }
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal Value { get; set; }

        public TransactionLine() {

        }

    }
}
