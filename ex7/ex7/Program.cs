using System.Text;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {  
                Console.OutputEncoding = Encoding.UTF8;

                const double PI = Math.PI;

                Console.Write("Nhập bán kính hình tròn: ");
                double r = double.Parse(Console.ReadLine());

                double dienTich = PI * r * r;

                Console.WriteLine("Diện tích hình tròn là: " + dienTich);
            }
    }
}
