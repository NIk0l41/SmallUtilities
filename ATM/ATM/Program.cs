using System;

namespace ATM
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nikolai Banking!");
            Console.WriteLine("Please enter your credit card number: ");
            string input = Console.ReadLine();
            try
            {
                long cardNo = Convert.ToInt64(input);
                OnEnterCard(cardNo);
            }
            catch (Exception e) {
                Print(e.Message);
            }
        }

        static void OnEnterCard(long cardNo) {
            Console.WriteLine("Lovely! Now, enter your PIN number: ");
            string input = Console.ReadLine();
            try
            {
                int pinNo = Convert.ToInt32(input);
                string message = TripleDES(cardNo, pinNo);
                verObj verif = new verObj(message);
                if (!verif.valid)
                {
                    Console.WriteLine(verif.error);
                }
                else {
                    ContinueTATM(cardNo);
                }
            }
            catch (Exception e)
            {
                Print(e.Message);
            }
        }

        static string TripleDES(long cardNo, int pinNo) {
            string message = cardNo.ToString() + pinNo.ToString();
            string output = DES(DES(DES(message)));
            return output;
        }

        static string DES(string message) {
            return message;
        }

        static void Print(string a) {
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }

    public class verObj{
        public bool valid;
        public string error;
        public string input;

        public verObj(string input) {
            valid = CheckValid(input);
        }

        bool CheckValid(string input) {
            return true;
        }
    }
}
