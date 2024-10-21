using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobil lol1= new Automobil(1, "Audi", "S3", 4500, 200000);
            Automobil lol2 = new Automobil();
            ElektricniAuto lel1 = new ElektricniAuto(2, "Audi", "Etron", 20000, 125000, 95);

            lol1.Ispis();
            lol2.Ispis();
            lel1.Ispis();

            lol1.PromCena(10);
            lol2.PromCena(10);
            lel1.PromCena(20);

            Console.WriteLine("\nPosle Promen");
            lol1.Ispis();
            lol2.Ispis();
            lel1.Ispis();
            
            Console.ReadLine();

        }
    }
}
