using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Téglatest : Testek
    {
        public double a;
        public double b;
        public double c;

        public Téglatest(double a, double b, double c) :base("Téglatest")
        {
            this.a=a;
            this.b=b;
            this.c=c;
        }

        public double A { get => a;}
        public double B { get => b;}
        public double C { get => c;}

        public override double Felszin()
        {
            return 2*(a*b+a*c+b*c);
        }

        public override double Terfogat()
        {
            return a*b*c;
        }
    }
}
