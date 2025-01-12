namespace Assignment3
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
            Console.WriteLine("Enter Car make: ");
            string make = Console.ReadLine();

            Console.WriteLine("Enter car model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Enter car year: ");
            int year = int.Parse(Console.ReadLine());

            Car car = new Car(make, model, year);

            car.DisplayCarDetails();
        }
    }
}
