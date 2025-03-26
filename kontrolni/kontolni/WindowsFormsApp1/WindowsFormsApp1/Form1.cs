using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary1;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form, Ranglista
    {
      
        public List<Kandidat> kandidati = new List<Kandidat>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            double poeni = Convert.ToDouble(txtPoeni.Text);
            int sif = Convert.ToInt32(txtSF.Text);
            
            Kandidat kandidat = new Kandidat(ime, prezime, poeni, sif);
            kandidati.Add(kandidat);
            
            lbKandidati.Items.Add(kandidat.Pirkaz());
        }
        
        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            int brkandidata = Convert.ToInt32(txtPrim.Text);
            int sifraFakulteta = Convert.ToInt32(txtSifpretrafa.Text);
            List<Kandidat> primljeni = Spisak(brkandidata, sifraFakulteta);
            lbRangLista.Items.Clear();  
             foreach (Kandidat kandidat in primljeni)
            {
                lbRangLista.Items.Add(kandidat.Pirkaz());
            }
        }
        
        public List<Kandidat> Spisak(int brkandidata, int siffak)
        {
          
            List<Kandidat> sortirani = Sortiranje.SortirajK(kandidati, siffak);
            List<Kandidat> rezultat = new List<Kandidat>();
            
            foreach (Kandidat k in sortirani)
            {
                if (k.SifFak == siffak)
                {
                    rezultat.Add(k);
                    if (rezultat.Count >= brkandidata)
                        break;
                }
            }

            return rezultat;
        }
    }

    public static class Sortiranje
    {
        public static List<Kandidat> SortirajK(List<Kandidat> kandidati, int siffak)
        {
            List<Kandidat> sort = new List<Kandidat>();

            foreach (Kandidat k in kandidati)
            {
                if (k.SifFak == siffak)
                {
                    sort.Add(k);
                }
            }

           sort.Sort((k1, k2) => k2.Brpoena > k1.Brpoena ? 1 : -1);

            return sort;
        }
    }
}
