using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace isplata_zarada
{
    abstract class Osoba
    {
        protected int sif;
        protected string ime_prezime;
        protected string ziro_racun;

        abstract public void RacunajPlatu();

        abstract public string Prikaz();
        
        public Osoba(int s, string ime, string racun)
        {
            sif = s;
            ime_prezime = ime;
            ziro_racun = racun;
        }
    }

    class Zaposleni : Osoba , IBank
    {
        private int zarada, brsati, vrsata, stanje;
        
        public static int ukupno;

        public Zaposleni(int s, string ime ,string racun, int brsati, int vrsata):base(s,ime,racun)
        {
            this.brsati = brsati;
            this.vrsata = vrsata;
        }

        public override void RacunajPlatu()
        {
            zarada = brsati * vrsata;
        }

        public override string Prikaz()
        {
            return sif.ToString() + " " + ime_prezime + " " + ziro_racun.ToString();
        }

        public int Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }

        public void Uplata(int iznos, string racun)
        {
            stanje += iznos;
        }

        public int Isplata(int iznos, string racun)
        {
            iznos = iznos - Zarade.Porez(iznos, 10);
            if (iznos >= stanje)
            {
                stanje -= iznos;
                return iznos;
            }
            else return 0;
        }
    }
}
