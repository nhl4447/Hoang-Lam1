namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 5, b = 10;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
