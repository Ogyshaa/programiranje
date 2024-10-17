using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompleksni_br
{
    class Kompleksni
    {
        private double x;
        private double y;
    
        public double X
            {
                get{return x;}
                set{x=value;}
            }
               public double Y
            {
                get{return y;}
                set{y=value;}
            }
        public Kompleksni()
{
    x = 0;
    y = 0;

}
public Kompleksni(double x, double y)
{
    this.x = x;
    this.y = y;
}
public Kompleksni Zbir(Kompleksni z1)
{
    Kompleksni z = new Kompleksni();
    z.x = this.x + z1.x;
    z.y = this.y + z1.y;
    return z;
}
public void Ispisati()
{
    Console.WriteLine("z=" + x + "i" + y);
}
    }
}
