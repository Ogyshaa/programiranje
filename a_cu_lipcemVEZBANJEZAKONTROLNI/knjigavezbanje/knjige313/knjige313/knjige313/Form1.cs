using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using knjigadll;
namespace knjige313
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Knjiga k;
        List<Knjiga> Spisak;
        List<string> Lista;
        int svega = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Spisak = new List<Knjiga>();
            Lista = new List<string>();
        }

        private void btdodaj_Click(object sender, EventArgs e)
        {
            int sifra = Convert.ToInt32(txtsifra.Text);
            int cena = Convert.ToInt32(txtcena.Text);
            int brkom = Convert.ToInt32(txtbrkom.Text);
            string naziv = txtnaziv.Text;
            k = new Knjiga(sifra, naziv, cena, brkom);
            Spisak.Add(k);
            string s = k.Prikazi();
            Lista.Add(s);
            LBox.PrikaziLB(lbknjige, Lista);
            lblukupno.Text = Knjiga.ukupno.ToString();


        }

        private void btprodaja_Click(object sender, EventArgs e)
        {
            int i = LBox.LBSelIndex(lbknjige);
            k = Spisak[i];
            int br = Convert.ToInt32(txtpbr.Text);
            if (k.Prodaja(br) > 0)
            {
                svega += k.Prodaja(br);
                lblsvega.Text = svega.ToString();
                lblukupno.Text = Knjiga.ukupno.ToString();
                Lista[i] = k.Prikazi();
                LBox.PrikaziLB(lbknjige, Lista);
            }
            else
                MessageBox.Show("Nema dovoljan broj zahtevane knjige !!!");

        }
    }
}
