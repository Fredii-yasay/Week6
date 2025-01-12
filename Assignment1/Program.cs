namespace Assignment1
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
            Console.WriteLine("Enter person's name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter person's age: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(name, age);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
