using System;

namespace Quizlet_Hacks
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Quizlet Hacks";
            bool showMenu = true;
            while (showMenu) {
                showMenu = LoadMenu();
            }

        }

        private static bool LoadMenu() {
            Console.Clear();
            Console.WriteLine("Function:");
            Console.WriteLine("1) Sine Rule");
            Console.WriteLine("2) Cosine Rule");
            Console.WriteLine("3) Determine Binomial Probability");
            Console.WriteLine("0) Exit");

            switch (Console.ReadLine()) {
                case "1":
                    SineMenu();
                    return true;
                case "2":
                    CosineMenu();
                    return true;
                case "3":
                    BinoMenu();
                    return true;
                case "4":
                    int m;
                    double C, q;
                    double p = 3 / 4;
                    int n = 10;
                    int x = 3;
                    q = 1 - p;
                    m = n - x;
                    long nl, xl, dl;
                    nl = Factorial(Convert.ToInt64(n));
                    xl = Factorial(Convert.ToInt64(x));
                    dl = Factorial(Convert.ToInt64(m));
                    C = (nl) / (xl * dl);
                    Print(C);
                    double a = C * Math.Pow(p, x) * Math.Pow(q, m);
                    Print(Math.Pow(p, x));
                    Print(Math.Pow(q, m));
                    Print(a);
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        static void Print(double input) {
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
