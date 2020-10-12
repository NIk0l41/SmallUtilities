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
                case "9":
                    Debug();
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

        static void Say(string input) {
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
