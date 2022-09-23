using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class BankAccount
    {
        private double _balance = 0;


        public void deposit (double amount)
        {
            Console.WriteLine($"simulating a deposit of (amount,0:c) to your account");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
       
    }
}
