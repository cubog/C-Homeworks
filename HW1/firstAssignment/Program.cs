using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("The area is: "+ area(width, length));
            Console.ReadLine();
        }
        
        static double area(double width, double length)
        {
            return length * width;
        }
    }
}
