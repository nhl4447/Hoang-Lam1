using System.Text;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập độ dài cạnh hình vuông: ");
            double canh = double.Parse(Console.ReadLine());

            double dienTich = canh * canh;

            Console.WriteLine("Diện tích hình vuông là: " + dienTich);
        }
    }
}
