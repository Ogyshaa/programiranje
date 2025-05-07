using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventtt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MaturaMonitor upravljac;
        MaturskiIspit m1;

        private void Form1_Load(object sender, EventArgs e)
        {
            m1 = new MaturskiIspit();
            upravljac = new MaturaMonitor(m1);

            // Pretpostavka: povezana su KeyPress događaji sa TextBox-ovima
            txtSrp.KeyPress += txt_KeyPress;
            txtPraksa.KeyPress += txt_KeyPress;
            txtTest.KeyPress += txt_KeyPress;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int ocena;
                if (int.TryParse((sender as TextBox).Text, out ocena))
                {
                    string name = (sender as TextBox).Name;

                    if (name == "txtSrp")
                        m1.Srpski = ocena;
                    else if (name == "txtPraksa")
                        m1.Praksa = ocena;
                    else if (name == "txtTest")
                        m1.Test = ocena;
                }

                e.Handled = true; // sprečava zvuk Entera
            }
        }
    }
}