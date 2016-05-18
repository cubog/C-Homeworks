using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            getTable(num);
            Console.ReadLine();
        }

        static void getTable(int num)
        {
            int multiplier = 1;
            for (int i = 1;i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(j * multiplier + " ");
                }
                Console.Write("\n");
                multiplier++;
            }
        }

    }
}
