using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvadradtna_jed
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
        KvadratnaJed k1;
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtb1.Text);
            b = Convert.ToDouble(txtb2.Text);
            c = Convert.ToDouble(txtb3.Text);
            k1 = new KvadratnaJed(a,b,c);

            /*
                k1=new KvadratnaJed();
                k1.A=a;
                ...
            */
            label4.Text = k1.Diskriminatna();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
