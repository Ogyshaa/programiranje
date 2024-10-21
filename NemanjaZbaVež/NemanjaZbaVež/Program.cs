
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaZbaVež
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gorivo[] gorivos = new Gorivo[5];
            gorivos[0] = new Gorivo(505,  "dijabola", "m", 16, 100,20);
            gorivos[1] = new Gorivo(545, "dijabla", "m", 56, 100, 24);
            gorivos[2] = new Gorivo(535, "dibola", "m", 46, 100, 23);
            gorivos[3] = new Gorivo(515, "ola", "m", 36,100, 22);
            gorivos[4] = new Gorivo(525, "jabola", "m", 26,100, 21);

            for (int i = 0; i < gorivos.Length; i++)
            {
                gorivos[i].Prikazi();
                gorivos[i].Promena(2);
            }
            for(int i = 0; i < gorivos.Length; i++)
            {
                gorivos[i].Prikazi();
            }
            Console.ReadLine();
        }      
    }
}
