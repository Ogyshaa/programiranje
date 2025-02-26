using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura
{
    public partial class Form1 : Form
    {

        private double a, b;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txta.Text);
            double b = Convert.ToDouble(txtb.Text);

            Pravougaonik prav = new Pravougaonik(a, b);

            lbobim.Text = prav.Obim().ToString();
            lbpov.Text = prav.Povrsina().ToString();

            Krug krug = new Krug(a);
            lbOblik1.Text = "Prečnik: " + krug.Oblik1().ToString();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
