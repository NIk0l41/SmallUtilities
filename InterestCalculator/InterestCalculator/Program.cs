using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Menu() {
            bool active = true;
            while (active) {
                Console.Title = "Interest Calculator";
                Console.WriteLine();
                SimpleInterest();
            }
        }
        
        static void SimpleInterest() {
            Console.Title = "Interest Calculator - Simple Interest";
            Console.Write("Initial Amount: $");
            try
            {
                double p = Convert.ToDouble(Console.ReadLine());
                Console.Write("Interest Rate: %");
                try
                {
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Years of Investment: ");
                    try {
                        int t = Convert.ToInt32(Console.ReadLine());
                        double I = p * r/100 * t;
                        Console.WriteLine("End Value: $" + I);
                        Console.Write("Total Interest: $" + (I - p));
                        Console.ReadLine();
                    }
                    catch {
                        Console.WriteLine("Please insert an integer value.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please insert a valid value.");
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Please insert a monetary value.");
                Console.ReadLine();
            }
        }

        static void CompoundInterest() {
            Console.Title = "Interest - Compound Interest";
            Console.Write("Inital Ammount");
        }
    }
}
