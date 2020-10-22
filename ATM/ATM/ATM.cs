using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    partial class Program
    {
        static void ContinueTATM(long cardNo) {
            Account acc = new Account(cardNo);
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Deposit");
            Console.WriteLine("2) Withdraw");
            Console.WriteLine("3) Return Card");
            string input = Console.ReadLine();
            switch (input) {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        }

        static void Deposit(Account acc){

        }

        static void ModifyAccountBalance(Account acc, float value, int type) {
            if (type == 1) {
                value *= -1;
            }
            //Account Balance
        }
    }

    class Account {
        string bsb;
        string number;
        float balance;
        public string BSB { get { return bsb; } }
        public string Number { get { return number; } }
        public float Balance { get { return balance; } set { balance = value; } }

        IDictionary<long, string> accountNumbers;
        IDictionary<long, string> bsbNumbers;

        public Account(long cardNo) {
            LoadAccountDictionary();
            LoadBSBDictionary();
            bsb = accountNumbers[cardNo];
            number = bsbNumbers[cardNo];
        }

        void LoadAccountDictionary(){
            accountNumbers.Add(123456789, "11111111");
        }

        void LoadBSBDictionary() {
            bsbNumbers.Add(123456789, "11-1111");
        }
    }
}
