using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Hacks
{
    partial class Program
    {
        /// <summary>
        /// The menu for further Sine Functions.
        /// </summary>
        private static void SineMenu()
        {
            Console.Clear();
            Console.WriteLine("Do you want to find:");
            Console.WriteLine("1) Angle");
            Console.WriteLine("2) Side Length");
            Console.WriteLine("0) Nvm, take me back");

            switch (Console.ReadLine())
            {
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

        /// <summary>
        /// Uses the Sine rule to return a desired angle.
        /// </summary>
        private static void SineFindAngle()
        {
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
                        Say("Output: B = " + A);
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
            catch (Exception e)
            {
                Say(e.Message);
            }
        }

        /// <summary>
        /// Uses the Sine Rule to return the desired side length
        /// </summary>
        private static void SineFindSide()
        {
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
                try
                {
                    double b = Convert.ToDouble(_b);
                    try
                    {
                        double B = Convert.ToDouble(_B);
                        double C = Math.PI / 180;
                        double a = ((C * Math.Sin(A * C) * b) / (C * Math.Sin(B * C)));
                        Say("Output: a = " + a);
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
            catch (Exception e)
            {
                Say(e.Message);
            }

        }

        /// <summary>
        /// The menu for further Cosine Functions
        /// </summary>
        private static void CosineMenu()
        {
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

        /// <summary>
        /// Uses the Cosine Rule to return a desired angle.
        /// </summary>
        private static void CosineFindAngle()
        {
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
                        Say("Output: C = " + C);
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
            catch (Exception e)
            {
                Say(e.Message);
            }
        }

        /// <summary>
        /// Uses the Cosine Rule to return a desired side length.
        /// </summary>
        private static void CosineFindSide()
        {
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
                        Say("Output: c = " + c);
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
            catch (Exception e)
            {
                Say(e.Message);
            }
        }

    }
}
