using System;


namespace VariableTypeDemo
{
    public class Account
    {
        public const String bankname = "NABIL";

        public static int TotalAccount = 0;

        public string accountHolder;
        public double balance;
        public readonly string AccountID = "HI";


        public Account(string holder, string id, double initalBalance)
        {
            accountHolder = holder;
            AccountID = id;
            balance = initalBalance;
            TotalAccount = 30;
        }

        //method to show account info

        public void DisplayAccountInfo()
        {
            string infoHeader = "Account Info";
            Console.WriteLine(infoHeader);
            Console.WriteLine($"Bank:{bankname}"); //string interpolation 
            Console.WriteLine($"Holder : {accountHolder}");
            Console.WriteLine($"AccountId : {AccountID}");
            Console.WriteLine($"balacne:{balance}");
            Console.WriteLine($"Total  account  : {TotalAccount}");
        }

        public class program
        {


            static void Main(string[] args)
            {
                Account acc1 = new Account("ram", "ACC123", 15000.52);
                Account acc2 = new Account("sita", "ACC456", 157111.3);

                acc1.DisplayAccountInfo();
                acc2.DisplayAccountInfo();

                Console.WriteLine($"total account created:{Account.TotalAccount}");

            }
            
        }
    }
}