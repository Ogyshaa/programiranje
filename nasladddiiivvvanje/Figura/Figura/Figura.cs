using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    abstract class Figura
    {
        protected double a, b;

        public Figura(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public abstract double Obim();

        public abstract double Povrsina();
    }

    public interface Oblik
    {
        double Oblik1();
    }


    class Pravougaonik : Figura
    {

        public Pravougaonik(double a, double b): base (a,b)
        {
           
        }
        public override double Povrsina()
            {
                return a*b;
            }
        public override double Obim()
            { 
                return (a + b)*2;
            }
    }
    class Krug : Figura, Oblik
    {
        public Krug(double a) : base(a, 0)
        {
        }

        public override double Povrsina()
        {
            return Math.PI * Math.Pow(a,2);
        }

        public override double Obim()
        {
            return 2 * Math.PI * a; 
        }
        public double Oblik1()
        {
            return 2 * a; 
        }
    }
}