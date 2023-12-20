using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CheckingAccount:Account
    {
        private const double withdrawal=1.50;

        public CheckingAccount(string name = "none", double balance = 0.0,double withdrwal=1.50 ): base(name, balance)
        {
            balance = balance;
        }

        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount+ withdrawal);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {GetBalance()}";
        }
    }
}
