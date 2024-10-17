using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTrougao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Trougao t;
        double a, b, c;

        private void txtb_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(txtb.Text, out b))
            {
                txtb.Text = "";
                txtb.Focus();
            }
        }

        private void txtc_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(txtc.Text, out c))
            {
                txtc.Text = "";
                txtc.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out a))
            {
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out a))
            {
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void btnRcunaljka_Click(object sender, EventArgs e)
        {
            if (a + b > c && b + c > a && c + a > b)
            {
                t = new Trougao(a, b, c);
                double o, p;
                t.ObimP(out o, out p);
                lblO.Text = o.ToString();
                lblP.Text = p.ToString();
            }
            else
            {
                MessageBox.Show("Stranice ne čine trougao )); !!!");
                textBox1.Focus();
            }
        }
    }
}