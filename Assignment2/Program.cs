namespace Assignment2
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
            Console.WriteLine("Enter book's author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Enter book's title: ");
            string title = Console.ReadLine();

            Book book = new Book(title, author);

            book.DisplayBook();
        }
    }
}
