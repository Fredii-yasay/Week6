namespace Assignment6
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
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Account account = new Account(name);

            Console.WriteLine("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
        }
    }
}
