using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CompoundInterest();   
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
                        I = Math.Round(I, 2);
                        Console.WriteLine("End Value: $" + I);
                        Console.Write("Total Interest: $" + (I - p));
                        Console.ReadLine();
                    }
                    catch {
                        UserError();
                    }
                }
                catch {
                    UserError();
                }
            }
            catch {
                UserError();
            }
        }

        static void CompoundInterest() {
            Console.Title = "Interest - Compound Interest";
            Console.Write("Inital Ammount: $");
            try
            {
                double P = Convert.ToDouble(Console.ReadLine());
                Console.Write("Interest Rate: %");
                try {
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Years of Investment: ");
                    try {
                        int t = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Numbers of Compounds per Year: ");
                        try {
                            int n = Convert.ToInt32(Console.ReadLine());
                            double A = P * Math.Pow((1 + (r / 100 / n)), (n * t));
                            A = Math.Round(A, 2);
                            double B = A - P; ;
                            B = Math.Round(B, 2);
                            Console.WriteLine("End Value: $" + A);
                            Console.Write("Total Interest: $" + B);
                            Console.ReadLine();
                        }
                        catch {
                            UserError();
                        }
                    }
                    catch {
                        UserError();
                    }
                }
                catch {
                    UserError();
                }
            }
            catch {
                UserError();
            }
        }

        static void UserError() {
            Console.WriteLine("Come on Mate.");
            Console.WriteLine("You wrote the damn program, do better.");
            Console.WriteLine("*sigh*");
            Console.ReadLine();
        }
    }
}
