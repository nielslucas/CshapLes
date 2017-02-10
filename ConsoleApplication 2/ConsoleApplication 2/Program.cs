using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_2
{
    class Account
    {
        private decimal _balance;

        //constructer
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }// end constructer

        public void Credit(decimal amount)
        {
            Balance = Balance + amount;
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value >= 0)
                    _balance = value; 
            }
        }
    }//end Account

    class AccountTest
    {
        public static void Main(string[] args)
        {
            Account account1 = new Account(50.00m);
            Account account2 = new Account(-7.53m);

            //account 1 balance
            Console.WriteLine("account1 balance:{0}", account1.Balance);
            //account 2 balance
            Console.WriteLine("account2 balance:{0}", account2.Balance);

            decimal depositAmount;

            //deposite for account 1
            Console.Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding to account1 balance\n", depositAmount);
            account1.Credit(depositAmount);

            //account 1 balance
            Console.WriteLine("account1 balance:{0}", account1.Balance);
            //account 2 balance
            Console.WriteLine("account2 balance:{0}", account2.Balance);

            //deposite for account 2
            Console.Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding to account1 balance\n", depositAmount);
            account2.Credit(depositAmount);

            //account 1 balance
            Console.WriteLine("account1 balance:{0}", account1.Balance);
            //account 2 balance
            Console.WriteLine("account2 balance:{0}", account2.Balance);

            Console.ReadLine();
        }
    }

}//end namespace
