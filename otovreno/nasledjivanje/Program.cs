using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledjivanje312
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Marko Markovic", 2008);
            Ucenik u1 = new Ucenik("Janko Jankvoic", 2007,3,4.5)  ;
            Nastavnik n1 = new Nastavnik("Petar Petrovic",1980,90000);
            o1.PredstaviSe();
            u1.PredstaviSe();
            n1.PredstaviSe();
            Console.ReadLine();

            Osoba[] osobe = { o1, n1, n1, u1, o1, u1 };
            for (int i = 0; i < osobe.Length;i++)
            {
                osobe[i].PredstaviSe();
            }
            Console.ReadLine();
        }
    }
}
