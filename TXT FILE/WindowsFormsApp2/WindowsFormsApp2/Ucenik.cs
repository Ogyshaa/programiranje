using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Ucenik
    {
        private string ime, prezime;
        private int sifra;
        private List<int> ocene;

        public string Ime
        { get { return ime; } }
        public int Sifra
            { get { return sifra; } }
        public string Prezime
        { get { return prezime; } }
        public List<int> Ocene
        { get { return ocene; } }

        public Ucenik (string ime, string prezime, int sifra, List<int> ocene)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.sifra = sifra;
            this.ocene = ocene;
        }   

        public double Izracunaj()
        {
            double s = 0;
            for(int i=0;i<this.ocene.Count;i++)
            {
                s += ocene[i];
            }
            double pr=s/ocene.Count;
            return pr;
        }
        public string Prikazi()
        {
            return sifra + " " + ime + " " + prezime + " " + ocene;
        }
    }
}
