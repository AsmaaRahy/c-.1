using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    internal class Account
    {
        private decimal balance;
        private string name;
        public Account(string name, decimal startingBalance)
        {
            this.balance = startingBalance;
            this.name = name;
        }

        public string Name { 
            get {
                return name;
            } }

       

        public bool Withdraw(decimal amount) {
            if (balance - amount >= 0 && amount >0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Withdraw Faild");
                return false;
            }
        }
        public bool Deposit(decimal amountToDeposit) {

            //balance += amount;
            if (amountToDeposit > 0)
            {
                balance += amountToDeposit;
                return true;
            }
            else {
                Console.WriteLine("Deposit Faild");
                return false;

            }

        }

        public void Print()
        {
            Console.WriteLine($"Name: {name} \t Balance: {balance}");

        }
    }
}
