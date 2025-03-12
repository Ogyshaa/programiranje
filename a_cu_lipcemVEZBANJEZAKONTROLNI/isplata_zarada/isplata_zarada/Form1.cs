using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isplata_zarada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zaposleni x;
        List<Zaposleni> spisak;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblUkup_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spisak = new List<Zaposleni>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sif = Convert.ToInt32(txtSif.Text);
            int brs = Convert.ToInt32(txtBrs.Text);
            int vrs = Convert.ToInt32(txtVrs.Text);
            string ime = txtIme.Text;
            string racun = txtRac.Text;
            x = new Zaposleni(sif, ime, racun, brs, vrs);
            spisak.Add(x);

            lbZap.Items.Add(x.Prikaz());


        }

        private void btn_Click(object sender, EventArgs e)
        {
            int n = spisak.Count;

            lbZap.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                x = spisak[i];
                x.RacunajPlatu();
                lbZap.Items.Add(x.Prikaz());
            }
            /*
             foreach(Zaposleni x in spisak){
            x.RacunajPlatu();
            lbZap.Items.Add(x.Prikaz());
            }
             */
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            int indeks = lbZap.SelectedIndex;
            x = spisak[indeks];
            int iznos =Convert.ToInt32( txtIznos.Text)
            string rac = "";
            lblIznso.Text = x.Isplata(iznos, rac).ToString();
            lblUkup.Text = Zaposleni.ukupno.ToString();
        }
    }
}
