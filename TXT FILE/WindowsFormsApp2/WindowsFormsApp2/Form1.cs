using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Deployment.Application;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Design;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Ucenik> uceniks = new List<Ucenik>();
        Ucenik u;
        private void btnucitaj_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = @"C:\Users\veljko\Desktop\Programiranje";
            ofd.FilterIndex = 1;
            ofd.Filter = "|*.txt";
            ofd.Multiselect = false;

            string f = "";
            StreamReader sr = null;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                f = ofd.FileName;
                sr= new StreamReader(f);

                while (!sr.EndOfStream)
                {
                    string l = sr.ReadLine();
                    string[] niz = l.Split(' ');
                    int s = Convert.ToInt32(niz[0]);
                    string ime = niz[1];
                    string prezime = niz[2];
                    List<int> ocene = new List<int>();
                    for (int i = 0; i < 10; i++)
                    {
                        ocene.Add(int.Parse(niz[i+3]));
                    }
                    u = new Ucenik(ime, prezime,s,ocene);
                    uceniks.Add(u);
                }
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < uceniks.Count;i++)
            {
                string stavka="";
                stavka = uceniks[i].Ime + uceniks[i].Prezime + uceniks[i].Izracunaj();
                lb1.Items.Add(stavka);
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            sfd.InitialDirectory = @"C:\Users\veljko\Desktop\Programiranje";
            sfd.FilterIndex = 1;
            sfd.Filter = "|*.txt";

            StreamWriter sw;
            string f = "";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                f = sfd.FileName;
                sw = new StreamWriter(f);

                for(int i = 0; i < uceniks.Count;i++)
                {
                    sw.WriteLine(uceniks[i].Prikazi());
                }
            }
        }
    }
}
