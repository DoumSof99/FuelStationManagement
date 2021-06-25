using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl {
    public class FuelStation : Entity {

        public List<Customer> Customers { get; set; }
        public List<Item> Items { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Ledger> Ledgers { get; set; }

        public FuelStation() {

        }

    }
}
