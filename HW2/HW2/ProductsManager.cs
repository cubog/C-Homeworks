using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class ProductsManager
    {
        Products[] inventory;
        Products prod;
        private int num;
        private double SoldAmount;
        public ProductsManager()
        {
            inventory = new Products[20];
            num = 0;
            SoldAmount = 0;
        }

        public void AddItem(String name, int quantity, double price, string category)
        {
            prod = new Products(name,price, quantity,category);
            inventory[num] = prod;
            num++;
        }
        public Products SearchByName(String name)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    if (inventory[i].name.Contains(name))
                    {
                        return inventory[i];
                    }
                }
            }
            Console.WriteLine("Product not found");
            return null;
        }
        public void UpdatePrice(String name, double price)
        {
            Products product = SearchByName(name);
            if (!product.Equals(null))
            {
                product.price = price;
            }
        }
        public void UpdateQuantity(String name, int quantity)
        {
            Products product = SearchByName(name);
            if (!product.Equals(null))
            {
                product.quantity = quantity;
            }
        }
        public double TotalAmountSold()
        {
            return SoldAmount;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int TotalProducts()
        {
            int num = 0;
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    num++;
                }
            }
            return num;
        }
        public void ProductList()
        {
            Console.WriteLine("Here is a list of the products: ");
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    Console.WriteLine(inventory[i].ToString());
                }
            }
            Console.WriteLine();
        }

    }
}
