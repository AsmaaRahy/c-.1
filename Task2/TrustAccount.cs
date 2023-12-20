using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TrustAccount : SavingsAccount
    {
        private int withdrawalCount;

        public TrustAccount(string name = "none", double balance = 0.0, double intRate = 1.0,int withdrawalCount=default) :base(name,balance,intRate)
        {
            Name = name;
            Balance = balance;
            IntRate = intRate;
            WithdrawalCount = withdrawalCount;
        }

        public string Name { get; }
        public double Balance { get; }
        public double IntRate { get; }
        public int WithdrawalCount { get; }

        public override bool Deposit(double amount)
        {
            if(amount >= 5000)
            {
                amount += 50;
            } return base.Deposit(amount);

        }

        public new bool Withdraw(double amount)
        {
            // Check withdrawal restrictions
            if (withdrawalCount >= 3 || amount > GetBalance() * 0.2)
            {
                return false;
            }
            else
            {
                withdrawalCount++;
                return base.Withdraw(amount);
            }
        }


        }
}
