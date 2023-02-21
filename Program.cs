namespace ConsoleH2Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 2;
            Add2(ref amount);
            Console.WriteLine($"Nuværende værdi af amount er : {amount}");
            Console.ReadKey();
        }
        static void Add2(ref int a)
        {
            a += 2;
        }
    }
}