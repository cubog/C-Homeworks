using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsManager man = new ProductsManager();
            man.AddItem("banana", 10, 2.99, "fruits");
            man.AddItem("apple", 20, 0.89, "fruits");
            Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Please choose an option below: ");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Search for Product");
                Console.WriteLine("3. Display total number of products");
                Console.WriteLine("4. Update quantity of product");
                Console.WriteLine("5. Print Product list ");
                Console.WriteLine("6. Exit");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter name of product: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please enter price of product: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter quantity of product: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter category of product: ");
                        string category = Console.ReadLine();
                        man.AddItem(name, quantity, price, category);
                        break;
                    case 2:
                        Console.WriteLine("Please enter name of product to search: ");
                        string term = Console.ReadLine();
                        try
                        {
                            Products prod = man.SearchByName(term);
                            Console.WriteLine("Name: " + prod.name);
                            Console.WriteLine("Price: " + prod.price);
                            Console.WriteLine("Quantity: " + prod.quantity);
                            Console.WriteLine("Category: " + prod.category +"\n");
                            
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Item not found\n");
                        }
                        break;
                    case 3:
                        int num = man.TotalProducts();
                        Console.WriteLine("Total number of products is: " + num);
                        break;
                    case 4:
                        Console.WriteLine("What product would you like to update: ");
                        string UpdateName = Console.ReadLine();
                        Console.WriteLine("Enter new quantity: ");
                        int quant = int.Parse(Console.ReadLine());
                        try
                        {
                            Products prod = man.SearchByName(UpdateName);
                            prod.quantity = quant;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Item not found");
                        }
                        break;
                    case 5:
                        Console.WriteLine();
                        man.ProductList();
                        break;
                    case 6:
                        System.Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
