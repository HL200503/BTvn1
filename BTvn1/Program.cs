using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTvn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Giải phương trình bậc 2: ax^2 + bx + c = 0");
            Console.Write("Nhập a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            PTb2 ptb2 = new PTb2(a, b, c);
            ptb2.Giai();
        }
    }
}
