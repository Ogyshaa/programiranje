using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figure312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblraz_Click(object sender, EventArgs e)
        {

        }

        private void btnrac_Click(object sender, EventArgs e)
        {
            double a;
            Figura f;
            Krug kr;
            Kvadrat kv;
            if (!double.TryParse(txtb.Text, out a))
            {
                MessageBox.Show("Pogrsan podatak ):");
                txtb.Text = "";
                txtb.Focus();
            }
            if (Krug.Checked)
            {
                kr = new Krug(a);
                f = kr;
            }
            else
            {
                kv = new Kvadrat(a);
                f = kv;
            }
            f.Racunaj();
            lblraz.Text = f.Ispis();
        }
    }
}
