namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());

            int tong = a + b;

            Console.WriteLine("Tổng của hai số là: " + tong);
        }
    }
}
