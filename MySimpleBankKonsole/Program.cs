namespace MySimpleBankKonsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* Testing the SavingsAccount class
            SavingsAccount myAccount = new SavingsAccount();
            myAccount.AccountNumber = 123456;
            myAccount.Deposit(500);
            myAccount.GetBalance();
            myAccount.Withdraw(200);
            myAccount.GetBalance();
            // myAccount.Withdraw(400); // Testing the exception for insufficient funds
            Console.ReadLine();
            */

            // User interaction to create an account and perform transactions
            Console.Write("Enter your account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter initial deposit amount: ");
            decimal initialDeposit = decimal.Parse(Console.ReadLine());
            SavingsAccount userAccount = new SavingsAccount();
            userAccount.AccountNumber = accountNumber;
            userAccount.Deposit(initialDeposit);
            userAccount.GetBalance();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - Show Balance");
                Console.WriteLine("4 - Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                // Handle user choices
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            userAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "2":
                        Console.Write("Enter withdrawal amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                        {
                            userAccount.Withdraw(withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "3":
                        userAccount.GetBalance();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
