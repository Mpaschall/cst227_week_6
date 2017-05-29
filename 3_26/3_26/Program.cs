using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_26
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
            Console.WriteLine("Enter an amount to borrow.");
            borrowed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter an annual interest rate in percent form. e.g. 10 for 10%");
            monthInterest = ((Convert.ToDouble(Console.ReadLine()) / 100) / 12);
            Console.WriteLine("Please entere a monthly payment amount.");
            paid = Convert.ToDouble(Console.ReadLine());
            while (borrowed >= 0 && months < 1000)
            {
                paidInterest = borrowed * monthInterest;
                newAmount = (borrowed + paidInterest);
                borrowed = newAmount - paid;
                months++;
                Console.WriteLine("After " + months + " months, your loan is "
                    + string.Format("{0:0.00}", borrowed) + ". You paid $" + string.Format("{0:0.00}", paidInterest) + " interest.");
            }
            if (months < 1000)
            {
                Console.WriteLine("it took " + months + " months to pay off your loan.");
            }
            else if (months >= 1000)
            {
                Console.WriteLine("It will take more than 1000 months to pay off this loan");
            }
        }
    }
}
