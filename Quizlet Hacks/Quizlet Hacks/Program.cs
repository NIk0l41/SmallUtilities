using System;

namespace Quizlet_Hacks
{
    class Program
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
            Console.WriteLine("0) Exit");

            switch (Console.ReadLine()) {
                case "1":
                    SineRule();
                    return true;
                case "2":
                    CosineRule();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static void SineRule() {
            Console.Clear();
            Console.WriteLine("Do you want to find:");
            Console.WriteLine("1) Angle");
            Console.WriteLine("2) Side Length");
            Console.WriteLine("0) Nvm, take me back");

            switch (Console.ReadLine()) {
                case "1":
                    SineFindAngle();
                    break;
                case "2":
                    SineFindSide();
                    break;
                case "0":
                    break;

            }
        }

        private static void SineFindAngle() {
            Console.Clear();
            Console.Write("Side Length Opposing Angle: ");
            string _a = Console.ReadLine();
            Console.Write("Second Side Length: ");
            string _b = Console.ReadLine();
            Console.Write("Angle Opposing Second Side Length: ");
            string _B = Console.ReadLine();
            try
            {
                double a = Convert.ToDouble(_a);
                try
                {
                    double b = Convert.ToDouble(_b);
                    try
                    {
                        double B = Convert.ToDouble(_B);
                        double C = Math.PI / 180;
                        double A = C * Math.Asin(((a * (C * Math.Sin(B * C))) / b) * C);
                        Console.WriteLine("Output: B = " + A);
                        Console.ReadLine();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        private static void SineFindSide() {
            Console.Clear();
            Console.Write("Angle Opposing Side Length: ");
            string _A = Console.ReadLine();
            Console.Write("Second Side Length: ");
            string _b = Console.ReadLine();
            Console.Write("Angle Opposing Second Side Length: ");
            string _B = Console.ReadLine();
            try
            {
                double A = Convert.ToDouble(_A);
                try {
                    double b = Convert.ToDouble(_b);
                    try
                    {
                        double B = Convert.ToDouble(_B);
                        double C = Math.PI / 180;
                        double a = ((C * Math.Sin(A * C) * b) / (C * Math.Sin(B * C)));
                        Console.WriteLine("Output: a = " + a);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }

        private static void CosineRule() {
            Console.Clear();
            Console.WriteLine("Do you want to find:");
            Console.WriteLine("1) Angle");
            Console.WriteLine("2) Side Length");
            Console.WriteLine("0) Take me back to the, MENU");

            switch (Console.ReadLine())
            {
                case "1":
                    CosineFindAngle();
                    break;
                case "2":
                    CosineFindSide();
                    break;
                case "0":
                    break;

            }
        }

        private static void CosineFindAngle() {
            Console.Clear();
            Console.Write("Side Length Opposing Angle: ");
            string _c = Console.ReadLine();
            Console.Write("Second Side Length: ");
            string _a = Console.ReadLine();
            Console.Write("Third Side Length: ");
            string _b = Console.ReadLine();
            try
            {
                double a = Convert.ToDouble(_a);
                try
                {
                    double b = Convert.ToDouble(_b);
                    try
                    {
                        double c = Convert.ToDouble(_c);
                        double d = 180 / Math.PI;
                        double p = -(((c * c) - (a * a) - (b * b)) / (2 * a * b));
                        double C;
                        C = d * Math.Acos(p);
                        Console.WriteLine("Output: C = " + C);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        private static void CosineFindSide() {
            Console.Clear();
            Console.Write("Angle Opposing Side Length: ");
            string _C = Console.ReadLine();
            Console.Write("Second Side Length: ");
            string _a = Console.ReadLine();
            Console.Write("Third Side Length: ");
            string _b = Console.ReadLine();
            try
            {
                double a = Convert.ToDouble(_a);
                try
                {
                    double b = Convert.ToDouble(_b);
                    try
                    {
                        double C = Convert.ToDouble(_C);
                        double d = Math.PI / 180;
                        double c = Math.Sqrt((a * a) + (b * b) + (-2 * a * b) * Math.Cos(d * C));
                        Console.WriteLine("Output: c = " + c);
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

    }
}
