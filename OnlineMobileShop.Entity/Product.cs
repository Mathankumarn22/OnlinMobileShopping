using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMobileShop.Entity
{
    public class Product
    {
        public int MobileID { get; set; } 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Battery { get; set; }
        public int RAM { get; set; }
        public int ROM { get; set; }
        public int Price { get; set; }

        public Product(string Brand, string Model, int Battery, int RAM, int ROM, int Price)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Battery = Battery;
            this.RAM = RAM;
            this.ROM = ROM;
            this.Price = Price;
        }
        public Product(int MobileID)
        {
            this.MobileID = MobileID;
        }
    }
}
