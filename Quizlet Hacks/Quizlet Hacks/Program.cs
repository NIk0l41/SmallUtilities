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

        /// <summary>
        /// The Main Menu
        /// </summary>
        /// <returns>Whether the application should close or not.</returns>
        private static bool LoadMenu() {
            Console.Clear();
            Console.WriteLine("Function:");
            Console.WriteLine("1) Sine Rule");
            Console.WriteLine("2) Cosine Rule");
            Console.WriteLine("3) Determine Binomial Probability");
            Console.WriteLine("0) Exit");
            Console.WriteLine("");
            Console.WriteLine("9) Run Debug Functions");

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
                    Debug(deb);
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        /// <summary>
        /// A Makeshift Console.WriteLine Function for ease of typing.
        /// </summary>
        /// <param name="input">The desired number to print</param>
        static void Print(double input) {
            Console.WriteLine(input);
            Console.ReadLine();
        }

        /// <summary>
        /// A Makeshift Console.WriteLing Function for ease of typing.
        /// </summary>
        /// <param name="input">The desired string to print.</param>
        static void Say(string input) {
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
