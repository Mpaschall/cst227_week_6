using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double monthInterest = 0.01;
            double paidInterest = 0;
            double paid = 100;
            double borrowed = 1000;
            double newAmount = 0;
            int months = 0;
            Console.WriteLine("You borrow $1000");
            while (borrowed >= 0)
            {
                paidInterest = borrowed * monthInterest;
                newAmount = (borrowed + paidInterest);
                borrowed = newAmount - paid;
                months++;
                Console.WriteLine("After " + months + " months, your loan is " 
                    + string.Format("{0:0.00}", borrowed) + ". You paid $" + string.Format("{0:0.00}", paidInterest) + " interest.");
            }
            Console.WriteLine("it took " + months + " months to pay off your loan.");
        }
    }
}
