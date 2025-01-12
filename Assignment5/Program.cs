namespace Assignment5
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
            int value = 10;
            Console.WriteLine($"Original Value: {value}");

            ModifyByValue( value );
            Console.WriteLine($"After value modification: {value}");

            ModifyByReference( ref value );
            Console.WriteLine($"After reference modification: {value}");
        }

        public void ModifyByValue(int value)
        {
            value += 10;
        }

        public void ModifyByReference(ref int value)
        {
            value += 10;
        }
    }
}
