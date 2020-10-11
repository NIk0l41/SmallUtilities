using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Hacks
{
    partial class Program
    {
        static void BinoMenu() {
            Console.Clear();
            Console.WriteLine("What do you want to find?");
            Console.WriteLine("1) P(X=x)?");
            Console.WriteLine("2) P(a < X < b)?");
            Console.WriteLine("3) InvB");
            switch (Console.ReadLine()) {
                case "1":
                    BPDCD(true);
                    break;
                case "2":
                    BPDCD(false);
                    break;
                case "3":
                    //Goto INVB
                    break;
                default:
                    break;
            }
        }

        static void BPDCD(bool BPD) {
            Console.Clear();
            Console.Write("Number of Trials: ");
            string _a = Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(_a);
                Console.WriteLine("You must input the following as fraction form.");
                Console.WriteLine("Please use integers.");
                Console.Write("Numerator (Top): ");
                string _b = Console.ReadLine();
                try
                {
                    int f1 = Convert.ToInt32(_b);
                    Console.Write("Denominator: ");
                    string _c = Console.ReadLine();
                    try
                    {
                        int f2 = Convert.ToInt32(_c);
                        double f = Convert.ToDouble(f1/f2);
                        BinoDetermineCalc(BPD, n, f);
                    }
                    catch (Exception e){
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        static void BinoDetermineCalc(bool BPD, int n, double p) {
            switch (BPD) {
                case true:
                    Console.WriteLine("What 'x' value do you want to check?");
                    string _a = Console.ReadLine();
                    try
                    {
                        int x = Convert.ToInt32(_a);
                        double result = BinoSingle(n, x, p);
                        Console.WriteLine(result);
                        Console.ReadLine();
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    break;
                case false:
                    break;
            }
        }

        static long Factorial(long input) {
            long a = 1;
            for (int i = 0; i < input; i++) {
                a *= (i + 1);
            }
            return a;
        }

        static double BinoSingle(int n, int x, double p) {
            int m;
            double C, q;
            q = 1 - p;
            m = n-x;
            long nl, xl, dl;
            nl = Factorial(Convert.ToInt64(n));
            xl = Factorial(Convert.ToInt64(x));
            dl = Factorial(Convert.ToInt64(m));
            C = (nl) / (xl * dl);
            double a = C * Math.Pow(p, x) * Math.Pow(q, m);
            return a;
        }
    }
}
