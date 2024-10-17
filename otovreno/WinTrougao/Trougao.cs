using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTrougao
{
    class Trougao
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set{a= value;}
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Trougao()
        {
            a = 0; b = 0; c = 0;
        }
        public Trougao(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void ObimP(out double O, out double P)
        {
            double s;
            s = (a + b + c) / 2;
            P = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            O = a + b + c;
        }
    }
}
