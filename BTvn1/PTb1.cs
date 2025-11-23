using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTvn1
{
    internal class PTb1
    {
        protected double a, b;
        public PTb1(double a, double b)
        {
            this.a= a;
            this.b= b;
        }

        public virtual void Giai()
        {
            if (a==0)
            {
                if (b==0)
                    Console.WriteLine("Phương trình vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x= -b / a;
                Console.WriteLine("Phương trình có nghiệm x = {0}", x);
            }
        }
    }
}
