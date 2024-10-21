using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Salon
{
    internal class Automobil
    {
        private int id;
        private string marka;
        private string model;
        private double cena;
        private double km;

        public Automobil()
        {
            id = 0;
            marka = "lel";
            model = "lel";
            cena = 0;
            km = 0;
        }

        public Automobil(int id, string marka, string model, double cena, double km)
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.cena = cena;
            this.km = km;
        }

        public int Id
        { 
            get { return id; }  
            set { id = value; }
        }
        public string Marka
            { get { return marka; } set { marka = value; } }
        public string Model 
            { get { return model; } set { model = value; } }
        public double Cena
            { get { return cena; } set { cena = value; } }
        public double Km
            { get { return km; } set { km = value; } }

        public virtual void PromCena(double promena)
        {
            cena += cena * promena / 100;
        }

        public virtual void Ispis()
        {
            Console.WriteLine($"ID: {id}, marka: {marka}, model: {model}, cena: {cena} EURO, kilometraza {km } km");
        }
    }
    class ElektricniAuto : Automobil
    {
        private double kapacitetbat;

        public double KapacitetBat
        {
            get { return kapacitetbat; } set { kapacitetbat = value; }
        }
        public ElektricniAuto(int id, string marka, string model, double cena, double km, double kapacitetbat) : base(id, marka, model, cena, km)
        {
            this.kapacitetbat = kapacitetbat;
        }

        public override void PromCena(double promena)
        {
            base.PromCena(promena);
            Cena += Cena * 0.10;
        }

        public override void Ispis()
        {
            base.Ispis();
            Console.WriteLine($"kapacitet baterije {kapacitetbat} kWh");
        }
    }
}
