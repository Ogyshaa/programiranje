using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public double Brpoena { get; set; }
        
        public Ucenik(string ime, string prezime, double brponea)
        {
            Ime = ime;
            Prezime = prezime;
            Brpoena = brponea;
        }

        public virtual string Pirkaz()
        {
            return Ime +" " + Prezime + " " +Brpoena;
        }
    }
    public class Kandidat : Ucenik
    {
        public int SifFak { get; set; }

        public Kandidat(string ime, string prezime, double brpeona, int siffak) : base(ime, prezime, brpeona)
        {
            SifFak = siffak;
        }
        public override string Pirkaz()
        {
            return Ime + " " + Prezime + " " + Brpoena + " " + " " + SifFak;
        }

    }
}
