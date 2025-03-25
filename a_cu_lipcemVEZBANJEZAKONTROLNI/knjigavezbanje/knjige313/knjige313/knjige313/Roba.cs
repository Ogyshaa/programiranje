using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using knjigadll;
namespace knjige313
{
   abstract class Roba
    {
       protected int sifra;
       protected string naziv;
       protected int cena;
       public Roba(int s,string n,int c)
        {sifra = s; naziv = n;cena = c;}
       abstract public 
            int Prodaja(int brkom);
    }
    interface ITrgovina
    {
        int Iznos { get; set; }
        void Popust(int vrednost, int procenat);
    }
    class Knjiga : Roba ,ITrgovina
    {
        private int iznos;
        private int brkom;
        public int Brkom
        {
            get { return brkom; }
        }

        public static int ukupno;
        public int Iznos
        {
            get { return iznos; }
            set { iznos = value; }
        }
        public Knjiga(int s,string n,int c,int broj):
            base(s,n,c)
        {
            brkom = broj;
            ukupno += broj;
        }
      
        public void Popust(int vrednost,int procenat)
        {
            iznos = vrednost * procenat / 100;
        }

        public override 
            int Prodaja(int brkom)
        {
            int vrednost, procenat;
           
            if (brkom <= this.brkom)
            {
                vrednost = brkom * cena;
                procenat = 5;
                if (vrednost > 5000)
                    procenat = 10;
                Popust(vrednost, procenat);
                this.brkom -= brkom;
                ukupno -= brkom;
                return vrednost - iznos;
            }
            else
                return 0;
        }
        public string Prikazi()
        {
            return sifra.ToString() + " " +
                   naziv + " " +
                   cena.ToString() + " " +
                   brkom.ToString();
        }
    }
}
