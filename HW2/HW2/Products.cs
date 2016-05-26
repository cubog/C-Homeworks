using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Products
    {
        public string name;
        public double price { get; set; }
        public int quantity { get; set; }
        public string category;

        public Products(string name, double price, int quantity, string category)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
        }

        public override string ToString()
        {
            string result = "Name: " + name + "\n";
            result += "Price: " + price + "\n";
            result += "Quantity: " + quantity + "\n";
            return result;
        }


    }
}
