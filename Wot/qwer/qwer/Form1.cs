using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button btn1;
        Form form2;
        private void Form1_Load(object sender, EventArgs e)
        {
            btn1 = new Button();
            btn1.Size = new Size(50, 30);
            int x = this.ClientRectangle.Width / 2 - 25;
            int y = this.ClientRectangle.Height / 2 - 15;
            btn1.Location = new Point(x, y);
            btn1.Text = "login";
            btn1.Click += new EventHandler(btn1_OnClick);
            this.Controls.Add(btn1);
        }
        private void btn1_OnClick(object sender,EventArgs e)
        {
            form2 = new Form();
            form2.ShowDialog();
            form2.Load += new EventHandler(Form2_Load);
        }
        private void Form2_Load (object sender, EventArgs e)
        {
            TextBox txtuser = new TextBox();
            txtuser.Location = new Point(10, 10);
            txtuser.Size = new Size(50, 20);
            form2.Controls.Add(txtuser);
        }
    }
}
