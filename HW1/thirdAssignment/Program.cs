using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 1, 9, 11, 6 };
            Console.WriteLine(getMax2(arr));
            Console.ReadLine();
        }
        static int getMax2(int[] arr)
        {
            int max = 0;
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static int getMax1(int [] arr)
        {
            return arr.Max();
        }

    }
}
