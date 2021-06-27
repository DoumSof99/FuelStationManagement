using FuelStationManagementSystem.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationManagementSystem.Impl {
    public class Item : Entity {

        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        public Item() : base() {

        }

        public Item(string code, string description, ItemTypeEnum itemType, 
            decimal price, decimal cost) : base(){
            Code = code;
            Description = description;
            this.ItemType = itemType;
            Price = price;
            Cost = cost;

        }

    }
}
