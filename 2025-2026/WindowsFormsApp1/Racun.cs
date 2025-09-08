using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp1
{
    internal abstract class Racun
    {
        protected int broj;

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }
        public string Ime { get; set; }
        public double Stanje { get; protected set; }
        public Racun(int br, string name) {
            broj = br;
            Ime = name;
            Stanje = 0;
        }
        public abstract string Kamata();
        public string Uplata (double iznos)
        {
            Stanje += iznos;
            return "Uspesno ste upatili sredstva na racun";
        }
        public virtual string Isplata(double iznos)
        {
            if (Stanje >= iznos)
            {
                Stanje -= iznos;
                return "Mozete podici pare na blagajni";
            }
            else return "NO NO. Awww you have no money 😂😂😂😂😂😂";
           
        }
        public virtual string Izvestaj()
        {
            return "Stanje na racunu je " + Stanje + "din.";
        }

    }
    internal class Tekuci : Racun
    {
        double dozvoljeni = 30000;
        public double Dozvoljeni
        {
            get { return dozvoljeni; }
            set { dozvoljeni = value;}
        }
        public override string Isplata(double iznos)
        {
            Stanje -= iznos;
            if (Stanje>= iznos)
            {
                return "Mozete podici pare na blagajni🤑🤑🤑🤑🤑🤑🤑🤑🤑🤑🤑";
            }
            else
            {
               return "Paznja!!! Usli ste u minus😲";
            }
        }

        public override string Kamata()
        {
            if (Stanje >= 0)
                return "Nemate zateznu kamatu";
            else if (Stanje >= dozvoljeni)
                return "Negativna kamata za dozvoljeni minus je: -" + Stanje * 0.1;
            else
                return "Nedozvoljeni minus  😂🤦‍!!!! Idi radi bezposlicaru, uzecemo ti kucu😍😜🤞😎" + Stanje * 0.2;
        }
        public Tekuci(int br, string name): base(br,name)
        {

        }
    }

    internal class Stedni : Racun
    {
        public double Proc { get; set; }
        public override string Kamata()
        {
            return "IZnos od kamate je " + Stanje * Proc / 100;
        }
        public Stedni(int br, string name, double deposit, double proc) : base(br, name)
        {
            Stanje = deposit;
            Proc = proc;
        }
    }
}
