using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SavingsAccount:Account
    {
        protected double intRate;

        public SavingsAccount(string name = "none", double balance = 0.0, double intRate = 1.0)
            : base(name, balance)
        {

            this.intRate = intRate;
        }

        public virtual new bool Deposit(double amount)
        {
           
            amount = amount * (100 / intRate);
            return base.Deposit(amount);
        }

    

        public override string ToString()
        {
            return $"{base.ToString()}, {intRate}";
        }
    }
}
