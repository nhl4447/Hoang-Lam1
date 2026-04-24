namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập độ C: ");
            double c = double.Parse(Console.ReadLine());

            double f = (c * 9 / 5) + 32;

            Console.WriteLine("Độ F = " + f);

            // Ngược lại
            Console.Write("Nhập độ F: ");
            double f2 = double.Parse(Console.ReadLine());

            double c2 = (f2 - 32) * 5 / 9;

            Console.WriteLine("Độ C = " + c2);
        }
    }
}
