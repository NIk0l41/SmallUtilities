﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quizlet_Hacks
{
    partial class Program
    {
        /// <summary>
        /// The Binomial Probability Menu
        /// </summary>
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
                    INVB();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Runs the Input Menu for BCD and BPD, also provides the later calculations with 'n' and 'p'
        /// </summary>
        /// <param name="BPD">Determines whether the later function is BPD or BCD</param>
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

        /// <summary>
        /// Runs the menu for BCD and BPD
        /// </summary>
        /// <param name="BPD">Determines whether the function is BPD, or BCD</param>
        /// <param name="n">Number of Trials</param>
        /// <param name="p">Probability of Success</param>
        static void BinoDetermineCalc(bool BPD, int n, double p) {
            switch (BPD) {
                //BPD Function
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
                    ///BCD Function
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
                                Console.WriteLine("Final P: " + result2);
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

        /// <summary>
        /// Applies a factorial to the input, and returns the output
        /// </summary>
        /// <param name="input">Apply a factorial to this number</param>
        /// <returns></returns>
        static long Factorial(long input) {
            long a = 1L;
            for (int i = 0; i < input; i++) {
                a *= (i + 1);
            }
            return a;
        }

        /// <summary>
        /// Returns the binomial probabilty for a single discrete variable.
        /// </summary>
        /// <param name="n">The number of trials to perform</param>
        /// <param name="x">The discrete variable to return the probability for</param>
        /// <param name="p">The probability of success</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the binomial probability for a selection of Binomials Probabilities
        /// </summary>
        /// <param name="n">The number of trials to perform</param>
        /// <param name="p">The probability of success</param>
        /// <param name="ub">The upper bound of the selection</param>
        /// <param name="lb">The lower bound of the selection</param>
        /// <returns></returns>
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

        static void INVB() {
                
        }
    }
}
