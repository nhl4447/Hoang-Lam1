using System.Text;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Kích thước của các kiểu dữ liệu trong C#:\n");
                Console.WriteLine("Kiểu byte   : " + sizeof(byte) + " byte");
                Console.WriteLine("Kiểu sbyte  : " + sizeof(sbyte) + " byte");
                Console.WriteLine("Kiểu short  : " + sizeof(short) + " byte");
                Console.WriteLine("Kiểu ushort : " + sizeof(ushort) + " byte");
                Console.WriteLine("Kiểu int    : " + sizeof(int) + " byte");
                Console.WriteLine("Kiểu uint   : " + sizeof(uint) + " byte");
                Console.WriteLine("Kiểu long   : " + sizeof(long) + " byte");
                Console.WriteLine("Kiểu ulong  : " + sizeof(ulong) + " byte");
                Console.WriteLine("Kiểu char   : " + sizeof(char) + " byte");
                Console.WriteLine("Kiểu float  : " + sizeof(float) + " byte");
                Console.WriteLine("Kiểu double : " + sizeof(double) + " byte");
                Console.WriteLine("Kiểu decimal: " + sizeof(decimal) + " byte");
                Console.WriteLine("Kiểu bool   : " + sizeof(bool) + " byte");
        
        }
    }
}
    }
}
