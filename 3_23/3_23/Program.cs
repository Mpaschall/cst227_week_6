using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double inflation = 0.04;
            double entered = 0;
            double temp = 0;
            Console.WriteLine("Input the price of your item");
            entered = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                temp = ((entered * inflation) + entered);
                entered = temp;
            }
            Console.WriteLine("The price in three years will be $" + string.Format("{0:0.00}", entered));
        }
    }
}
