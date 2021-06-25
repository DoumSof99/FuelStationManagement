using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl {
    public class Customer : Person {

        public int CardNumber { get; set; }

        public Customer() : base() {

        }

    }
}
