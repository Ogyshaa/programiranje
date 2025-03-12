using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nekikuvarc
{
    public partial class Form1 : Form
    {
        private List<int> ocene = new List<int>();
        private Ucenik ucenik;

        public Form1()
        {
            InitializeComponent();
            ucenik = new Ucenik();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ucenik.Ime = txtIme.Text;
            ucenik.Prezime = txtPrezime.Text;

            if (int.TryParse(txtOcene.Text, out int ocena) && ocena >= 1 && ocena <= 5)
            {
                ocene.Add(ocena);
                liBoxOcene.Items.Add(ocena);
                txtOcene.Clear();
            }
            else
            {
                MessageBox.Show("Unesite validnu ocenu (1-5).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostaviGranicu_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGranica.Text, out double granica))
            {
                ucenik.Granica = granica;
                lblGranica.Text = $"Granica: {granica}";
            }
            else
            {
                MessageBox.Show("Unesite validnu granicu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpis_Click(object sender, EventArgs e)
        {
            double prosek = ucenik.Prosek(ocene);
            int rezultat = ucenik.Upis(prosek);

            string status = rezultat == 1 ? "budžet" : "samofinansiranje";
            MessageBox.Show($"Učenik {ucenik.Ime} {ucenik.Prezime} je upisan na {status}.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


