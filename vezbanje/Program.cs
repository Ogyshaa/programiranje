using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gorivo gorivo1 = new Gorivo(1, 150.0, "Benzin", "l", 50.0, 20.0);
            Gorivo gorivo2 = new Gorivo(2, 140.0, "Dizel", "l", 60.0, 15.0);
            Gorivo gorivo3 = new Gorivo(3, 130.0, "Plin", "l", 40.0, 10.0);
            

            // Prikazujemo informacije o svakom gorivu pre promene cene
            Console.WriteLine("Informacije o gorivu pre promene cene:");
            gorivo1.Prikazi();
            gorivo2.Prikazi();
            gorivo3.Prikazi();
            
            // Menjamo cenu za 2% za svako gorivo
            gorivo1.PromeniCenu(2);
            gorivo2.PromeniCenu(2);
            gorivo3.PromeniCenu(2);
            
            // Prikazujemo informacije o svakom gorivu nakon promene cene
            Console.WriteLine("\nInformacije o gorivu posle promene cene za 2%:");
            gorivo1.Prikazi();
            gorivo2.Prikazi();
            gorivo3.Prikazi();
            
            Console.ReadKey();
        }
    }
}