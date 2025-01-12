namespace Assignment4
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
            Console.WriteLine("Enter radius");
            int radius = int.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);

            circle.DisplayInfo();
        }
    }
}
