using System.Text;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số ngày: ");
            int tongNgay = int.Parse(Console.ReadLine());

            int nam = tongNgay / 365;
            int duNgay = tongNgay % 365;

            int tuan = duNgay / 7;
            int ngay = duNgay % 7;

            Console.WriteLine($"{tongNgay} ngày = {nam} năm, {tuan} tuần, {ngay} ngày");
        }
    }
}
