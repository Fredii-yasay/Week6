namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.WriteLine("What is your account number?");
            string accnumber = Console.ReadLine();

            BankAccount account = new BankAccount(accnumber, 0);
            int input;
            do
            {
                Console.WriteLine("Action:\n" +
                    "1. Deposit\n" +
                    "2. Withdraw\n" +
                    "3. Display Account\n" +
                    "0. Exit\n\n" +
                    "What would you like to do? (type number)");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter Deposit Amount: ");
                    double deposit = double.Parse(Console.ReadLine());

                    account.Deposit(deposit);
                }
                else if (input == 2)
                {
                    Console.WriteLine("Enter Withdraw Amount: ");
                    double withdraw = double.Parse(Console.ReadLine());

                    account.Withdraw(withdraw);
                }
                else if (input == 3)
                {
                    account.DisplayAccount();
                }
                else if (input == 0)
                {
                    Console.WriteLine("Exiting...");
                }
            }
            while (input != 0);
        }
    }
}
