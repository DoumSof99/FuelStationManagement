using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl
{
    public class Ledger : Entity
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        public Ledger() : base()
        {

        }
    }
}
