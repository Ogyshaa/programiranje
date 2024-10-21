    using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NemanjaZbaVež
{
    internal class Roba
    {
        protected int sifra;
        protected string naziv, jed_mere;
        protected double kolicina, cena;

        public Roba()
        {
            sifra = 0;
            naziv= jed_mere = "";
            kolicina = cena = 0;
        }
        public Roba (int sifra, string naziv, string jed_mere, double kolicina, double cena)
        {
            this.sifra = sifra; 
            this.naziv = naziv; 
            this.jed_mere= jed_mere;    
            this.kolicina= kolicina;   
            this.cena= cena;
        }

        public virtual void Promena(double procenat)
        {
            cena += cena * procenat / 100;
        }
        public virtual void Prikazi()
        {
            Console.WriteLine("Sifra:" + sifra + "naziv:" + naziv + "jed_mere" + jed_mere + "kolicina" + kolicina + "cena" + cena);
        }
    }
    class Gorivo : Roba
    {
        private double proc;

        public double Proc
        {
            get { return proc; }
            set { proc = value; }
        }

        public Gorivo(int sifra, string naziv, string jed_mere, double kolicina,double cena,double proc):base(sifra, naziv, jed_mere,kolicina,cena)
        {
            this.proc= proc;  
        }
        public override void Promena(double procenat)
        {
            cena += cena * procenat / 100;
            cena += cena * proc / 100;
        }
        public override void Prikazi()
        {
            Console.WriteLine("Sifra:   " + sifra + "   naziv: " + naziv + "    jed_mere:   " + jed_mere + "    kolicina   " + kolicina + " cena    " + cena+"  proc:     "+proc);
        }
    }
}
