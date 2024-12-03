using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Roba> robe = new List<Roba>();
        Roba r;
        private void btn_Click(object sender, EventArgs e)
        {
            string n;
            int s;
            double c, k;
            s = Convert.ToInt32(txtsifra.Text);
            n = txtnaziv.Text;
            k = Convert.ToDouble(txtkolicina.Text);
            c = Convert.ToDouble(txtcena.Text);

            r = new Roba(s, n, c, k);

            robe.Add(r);
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            sfd.InitialDirectory = @"C:\Users\veljko\Documents\Programiranje";
            sfd.Filter = "|*.dat";
            sfd.FilterIndex = 1;

            string f = "";
            FileStream fs = null;
            BinaryWriter bw = null;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                f = sfd.FileName;
                fs = File.Create(f);
                bw = new BinaryWriter(fs);
                for (int i = 0; i < robe.Count; i++)
                {
                    bw.Write(robe[i].Sifra);
                    bw.Write(robe[i].Naziv);
                    bw.Write(robe[i].Kolicina);
                    bw.Write(robe[i].Cena);
                }
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"C:\Users\veljko\Documents\Programiranje";
            ofd.Filter = "|*.dat";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            string f = "";
            FileStream fs = null;
            BinaryReader br = null;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                f = ofd.FileName;
                fs = File.OpenRead(f);
                br = new BinaryReader(fs);

                while(br.BaseStream.Position < br.BaseStream.Length)
                {
                    int s;
                    s = br.ReadInt32();
                    string n;
                    n = br.ReadString();
                    double k, c;
                    k = br.ReadDouble();
                    c = br.ReadDouble();

                    r = new Roba(s, n, k, c);
                    robe.Add(r);
                }
            }
        }

        private void btnlistaj_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<robe.Count;i++)
            {
                Lb1.Items.Add(robe[i].Prikazi());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            int s=Convert.ToInt32(txtpsifra.Text);
            double k=Convert.ToDouble(txtpkolicina.Text);
            double c = Convert.ToDouble(txtpcena.Text);
            for (int i = 0; i < robe.Count; i++)
            {
                if (robe[i].Sifra == s)
                {
                    robe[i].Nabavka(k, c);
                }
            }
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtsifrasell.Text);
            double k=Convert.ToDouble (txtkolicinasell.Text);

            for (int i = 0; i < robe.Count; i++)
            {
                if (robe[i].Sifra == s)
                {
                    robe[i].Prodaja(k);

                    lbpregled.Items.Add(robe[i].Prikazi());
                }
            }
        }
    }
}
