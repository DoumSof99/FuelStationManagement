using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl {
    public class Customer : Person {

        public string CardNumber { get; set; }

        public Customer(string name, string surname, string cardNumber) : base() {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
        }

    }
}
