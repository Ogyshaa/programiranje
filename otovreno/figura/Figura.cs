using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figure312
{
    class Figura
    {
        protected double dimenzaija;
        protected double obim;
        protected double povrsina;
        public Figura(double d)
        {
            dimenzaija = d;
        }
        public virtual void Racunaj()
        {
            povrsina = 0;
            obim = 0;
        }
        public string Ispis()
        {
            return "P= " + povrsina.ToString() + "O= " + obim.ToString();
        }
    }
    class Krug : Figura
    {
        public Krug(double dim) : base(dim)
        {
           
        }
        public override void Racunaj()
        {
            povrsina = Math.Round(Math.Pow(dimenzaija, 2) * Math.PI,2);
            obim = Math.Round(2 * dimenzaija * Math.PI,2);
        }

    }
    class Kvadrat : Figura
    {
        public Kvadrat(double dim) : base(dim)
        { }
        public override void Racunaj()
        {
            povrsina = Math.Pow(dimenzaija, 2);
            obim = 4 * dimenzaija;
        }
    }

}
