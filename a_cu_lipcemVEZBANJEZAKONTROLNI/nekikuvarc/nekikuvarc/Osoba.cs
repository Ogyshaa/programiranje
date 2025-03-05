using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nekikuvarc
{
    abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba() { }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        public abstract double Prosek(List<int> ocene);
    }

    class Ucenik : Osoba, Iupis
    {
        public double Granica { get; set; } = 60; // Podrazumevana granica

        public Ucenik() : base() { }

        public Ucenik(string ime, string prezime) : base(ime, prezime) { }

        public override double Prosek(List<int> ocene)
        {
            if (ocene.Count == 0)
                return 0;

            double suma = 0;
            foreach (int ocena in ocene)
                suma += ocena;

            return suma / ocene.Count;
        }

        public int Upis(double pr)
        {
            double vrednost = pr * 10 + 50;
            return vrednost <= Granica ? 1 : 0;
        }
    }
}
