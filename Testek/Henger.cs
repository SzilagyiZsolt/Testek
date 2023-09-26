using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Henger : Testek
    {
        public double m;
        public double r;

        public Henger(double m, double r) : base("Henger")
        {
            this.m = m;
            this.r = r;
        }

        public double M { get => m;}
        public double R { get => r;}

        public override double Felszin()
        {
            return 2* Math.PI*R*(R+M);
        }

        public override double Terfogat()
        {
            return Math.PI*R*R*M; 
        }
    }
}
