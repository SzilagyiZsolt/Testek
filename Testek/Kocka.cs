using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Kocka : Testek
    {
        public double a;

        public Kocka(double a) : base("Kocka")
        {
            this.a=a;
        }

        public double A { get => a;}

        public override double Felszin()
        {
            return 6*A*A;
        }

        public override double Terfogat()
        {
            return A*A*A;
        }
    }
}
