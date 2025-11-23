using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTvn1
{
    internal class PTb2 : PTb1
    {
        private double c;
        public PTb2(double a, double b, double c) : base(a, b)
        {
            this.c = c;
        }

        public override void Giai()
        {
            if (a==0)
            {
                PTb1 ptb1 = new PTb1(b, c);
                ptb1.Giai();
            }
            else
            {
                double delta = b*b-4*a*c;
                if (delta > 0)
                {
                    double x1 = (-b +Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b -Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else if (delta==0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép: x = {0}", x);
                }
                else
                {
                    Console.WriteLine("Phương trình không có nghiệm thực.");
                }
            }
        }
    }
}
