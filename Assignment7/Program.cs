namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program= new Program();
            program.Start();
        }

        void Start()
        {
            Console.WriteLine("Enter product: ");
            string product = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Product produkto = new Product(product, price);

            produkto.DisplayProduct();
        }
    }
}
