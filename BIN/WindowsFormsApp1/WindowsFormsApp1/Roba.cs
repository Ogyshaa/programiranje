using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Roba
    {
        private int sifra;
        private double kolicina;
        private string naziv;
        private double cena;

        public int Sifra
        { get { return sifra; } }
        public double Kolicina { get { return kolicina; } }
        public double Cena { get { return cena; } }
        
        public string Naziv { get { return naziv; } }

        public Roba(int sifra, string naziv, double kolicina, double cena)
        {
            this.sifra = sifra;
            this.kolicina = kolicina;
            this.naziv = naziv;
            this.cena = cena;
        }

        public void Nabavka(double kolicina, double cena)
        {
            this.kolicina += kolicina;
            this.cena= (cena + this.cena)/(kolicina+this.kolicina);
        }

        public double Prodaja(double kolicina)
        {
            if(kolicina <= this.kolicina)
            {
                this.kolicina-=kolicina;
            }
            return this.cena;
        }

        public string Prikazi()
        {
            return sifra + " " + naziv + " " + cena + " " + kolicina;
        }
    }
}
