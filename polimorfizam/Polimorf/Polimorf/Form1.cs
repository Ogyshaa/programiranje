using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Figura f;
        Krug cricle;
        Kvadrat k;
        Random r;
        Graphics g;
        int a;
        int yc;
        int xc;
        private void btnZI_Click(object sender, EventArgs e)
        {
            r = new Random();
            a = Convert.ToInt32(txtAAAAAAA.Text);
            int vrstaaaa = r.Next(1, 3);
            xc = ClientRectangle.Width / 2;
            yc = ClientRectangle.Height / 2;
            g = this.CreateGraphics();
            cricle = new Krug(a);
            k = new Kvadrat(a);
            if (vrstaaaa == 1)
                f = cricle;
            else
                f = k;
            Crtak(f);

           /* if (f is Krug)
            {
                label1.Text = "krug precinka" + a.ToString();
            }
            else if (f is Krug)
                label1.Text = "Kvadrat stranice" + a.ToString();
                */                
        }
        private void Crtak(Figura f)
        {
            f.CrtajFig(g,xc-a/2,yc-a/2);
            if (f as Krug != null)
            {
                label1.Text = (f as Krug).Prikazi1();
            }
            else
                label1.Text = (f as Kvadrat).Prikazi();

        }
        
    }
}
