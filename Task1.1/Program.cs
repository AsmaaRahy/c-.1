using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Task1._1
{
    enum MenuOption
    {
        withdraw=1, deposit,print,quit,
        option
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Account account1 = new Account("Jakes", 200000);
            //account1.Print();
            //account1.Deposit(100);
            //account1.Print();
            //account1.Withdraw(50);
            //account1.Print();
            //Console.WriteLine();
            Account account2 = new Account("Asmaa", 100000);
            //account2.Print();
            //account2.Deposit(1000);
            //account2.Print();
            //account2.Withdraw(5000);
            //account2.Print();
            

            static void ReadUserOption(Account account1, Account account2)
            {
                MenuOption option;

                do {
                    Console.WriteLine("Menu Options:");
                    Console.WriteLine("1.Withdraw ");
                    Console.WriteLine("2.Deposit ");
                    Console.WriteLine("3.Print ");
                    Console.WriteLine("4.Quit ");
                    Console.Write("Enter your choice: ");
                    option = (MenuOption)int.Parse(Console.ReadLine());

                    switch(option)
                    {
                        case MenuOption.withdraw:
                            DoWithdraw(account1);
                            break;
                        case MenuOption.deposit:
                            DoDeposit(account1);
                            break;
                        case MenuOption.print:
                            DoPrint(account1);
                            break;
                        case MenuOption.quit:

                            break;
                    }


                } while (option != MenuOption.quit && (option== MenuOption.withdraw || option == MenuOption.deposit || option == MenuOption.print));
                
            }
            ReadUserOption(account1, account2);

        }
        private static void DoDeposit(Account account)
        {
            Console.WriteLine("Enter Amount");

            account.Deposit(int.Parse(Console.ReadLine()));
        }
        private static void DoPrint(Account account)
        {
            account.Print();
        }
        private static void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter Amount");

            account.Withdraw(int.Parse(Console.ReadLine()));
        }

        
    }
}
