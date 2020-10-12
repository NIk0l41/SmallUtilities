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
                Console.WriteLine("Probability of Success");
                Console.WriteLine("You must input the following as fraction form.");
                Console.Write("Numerator (Top): ");
                string _b = Console.ReadLine();
                try
                {
                    int f1 = Convert.ToInt32(_b);
                    Console.Write("Denominator (Bottom): ");
                    string _c = Console.ReadLine();
                    try
                    {
                        int f2 = Convert.ToInt32(_c);
                        double f = Convert.ToDouble((double)f1/(double)f2);
                        BinoDetermineCalc(BPD, n, f);
                    }
                    catch (Exception e){
                        Say(e.Message);
                    }
                }
                catch (Exception e)
                {
                    Say(e.Message);
                }
            }
            catch (Exception e)
            {
                Say(e.Message);
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
                    catch (Exception e)
                    {
                        Say(e.Message);
                    }
                    break;
                case false:
                    Console.Write("Lower Bound: ");
                    string _b = Console.ReadLine();
                    try {
                        int lb = Convert.ToInt32(_b);
                        Console.Write("Upper Bound: ");
                        string _c = Console.ReadLine();
                        try
                        {
                            int ub = Convert.ToInt32(_c);
                            if ((ub - lb) > 0)
                            {
                                double result2 = BinoMulti(n, p, ub, lb);
                                Console.WriteLine(result2);
                                Console.ReadLine();

                            }
                            else {
                                Console.WriteLine("The bounds must have a positive difference.");
                                Console.ReadLine();
                            }
                        }
                        catch (Exception e)
                        {
                            Say(e.Message);
                        }
                    } catch (Exception e)
                    {
                        Say(e.Message);
                    }
                    break;
            }
        }

        static long Factorial(long input) {
            long a = 1L;
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

        static double BinoMulti(int n, double p, int ub, int lb) {
            int diff = ub - lb;
            double result = 0;
            for (int i = 0; i <= diff; i++)
            {
                double phi = BinoSingle(n, lb+ i, p);
                result += phi;
                Console.WriteLine(phi);
            }
            return result;
        }
    }
}
