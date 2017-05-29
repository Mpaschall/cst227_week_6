using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_20
{
    class Program
    {
        // I used the same code for 9_20 and 9_21 because they were both for the warehouse class.
        static void Main(string[] args)
        {
            string answer = "";
            string option = "";
            int r, t, c, amount;
            r = t = c = 0;
            Console.WriteLine("Do you want to create a default warehouse? yes/no");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                Warehouse warehouse = new Warehouse(0, 0, 0);
                Console.WriteLine("Your Warehouse has " + r + " radios, " + t + " tvs, and " + c + " computers");
                while (option != "quit")
                {
                    Console.WriteLine("What would you like to do next? add, remove, print? type quit to quit");
                    option = Console.ReadLine();
                    if (option == "add")
                    {
                        warehouse.addAmount();
                    }
                    else if (option == "remove")
                    {
                        warehouse.removeAmount();
                    }
                    else if (option == "print")
                    {
                        Console.WriteLine("Your warehouse has " + warehouse.getRadios() + " radios, " 
                            + warehouse.getTv() + " tvs, and " + warehouse.getComputer() + " computers." );
                    }
                }
            
            }
            else if (answer != "yes")
            {
                Console.WriteLine("Please enter the starting number of radios.");
                r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the starting number of tvs.");
                t = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the starting number of computers.");
                c = Convert.ToInt32(Console.ReadLine());
                Warehouse warehouse = new Warehouse(r, t, c);
                Console.WriteLine("Your Warehouse has " + r + " radios " + t + " tvs " + c + " computers");
                while (option != "quit")
                {
                    Console.WriteLine("What would you like to do next? add, remove, print? type quit to quit");
                    option = Console.ReadLine();
                    if (option == "add")
                    {
                        warehouse.addAmount();
                    }
                    else if (option == "remove")
                    {
                        warehouse.removeAmount();
                    }
                    else if (option == "print")
                    {
                        Console.WriteLine("Your warehouse has " + warehouse.getRadios() + " radios, "
                            + warehouse.getTv() + " tvs, and " + warehouse.getComputer() + " computers.");
                    }
                }
            
            }
        }
    }
}
