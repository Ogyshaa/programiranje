using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    internal class Roba
    {
        private int sifra;
        private double cena;
        private string naziv;
        private string jedMere;
        private double kolicina;

        // Podrazumevani konstruktor
        public Roba()
        {
            sifra = 0;
            cena = 0.0;
            naziv = "Nepoznato";
            jedMere = "kg";
            kolicina = 0.0;
        }

        // Sopstveni konstruktor
        public Roba(int sifra, double cena, string naziv, string jedMere, double kolicina)
        {
            this.sifra = sifra;
            this.cena = cena;
            this.naziv = naziv;
            this.jedMere = jedMere;
            this.kolicina = kolicina;
        }

        // Getter i Setter za Sifra
        public int Sifra
        {
            get{ return sifra; }
            set{ sifra = value;  }
        }

        // Getter i Setter za Cena
        public double Cena
        {
            get { return cena; } set { cena = value; }
        }

        // Getter i Setter za Naziv
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        // Getter i Setter za JedMere
        public string JedMere
        {
            get { return jedMere; }
            set { jedMere = value; }
        }

        // Getter i Setter za Kolicina
        public double Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        // Metoda za promenu cene
        public virtual void PromeniCenu(double procenatPromene)
        {
            cena += cena * procenatPromene / 100;
        }

        // Metoda za prikazivanje informacija o robi
        public virtual void Prikazi()
        {
            Console.WriteLine($"Sifra: {sifra}, Naziv: {naziv}, Cena: {cena} RSD, Količina: {kolicina} {jedMere}");
        }
    }

    // Izvedena klasa Gorivo
    class Gorivo : Roba
    {
        private double akciza;

        // Konstruktor
        public Gorivo(int sifra, double cena, string naziv, string jedMere, double kolicina, double akciza) : base(sifra, cena, naziv, jedMere, kolicina)
        {
            this.akciza = akciza;
        }

        // Getter i Setter za Akciza
        public double Akciza
        {
            get { return akciza; }
            set { akciza = value; }
        }
        // Pregazena metoda za promenu cene
        public override void PromeniCenu(double procenatPromene)
        {
            base.PromeniCenu(procenatPromene); // Promena po procentu
            Cena+=akciza; // Dodavanje akcize na cenu
        }

        // Pregazena metoda za prikazivanje informacija o gorivu
        public override void Prikazi()
        {
            Console.WriteLine($"Sifra: {Sifra}, Naziv: {Naziv}, Cena sa akcizom: {Cena} RSD, Akciza: {akciza} RSD, Količina: {Kolicina} {JedMere}");
        }
    }
}
