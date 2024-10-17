using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompleksni_br
{
    class Program
    {
        static void Main(string[] args)
        {
            Kompleksni a, b, c;
            a = new Kompleksni(5, 10);
            b = new Kompleksni(2, 3);
            c = new Kompleksni();
            c = a.Zbir(b);//b.Zbir(a);
            a.Ispisati();
            b.Ispisati();
            c.Ispisati();
            Console.ReadLine();
        }
    }
}
