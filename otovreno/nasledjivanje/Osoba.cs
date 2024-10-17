using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasledjivanje312
{
    class Osoba
    {
        protected string ime;
        protected int godina;
        public Osoba(string ime, int god)
        {
            this.ime = ime;
            godina = god;
        }
        public virtual void PredstaviSe()
        {
            Console.WriteLine(ime + " " + godina);
        }
    }
    class Ucenik : Osoba
    {
        private int razred;
        private double prosek;
        public Ucenik(string ime, int god, 
            int razred, double prosek) : base(ime, god)
        {
            this.razred = razred;
            this.prosek = prosek;
        }
        public override void PredstaviSe()
        {
            Console.WriteLine(ime + " " + godina + " " + razred +" "+ prosek);
        }
    }
    

    class Nastavnik : Osoba
    {
        private double neto;
        public Nastavnik(string ime, int godina, double plata):base(ime, godina)
        {
            neto = plata;
        }
        public override void PredstaviSe()
        {
            Console.WriteLine(ime + " " + godina +" "+ neto);
        }

    }


}
