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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 from1;
        private string USER;
        private TextBox txtypass;
        private Button btnOK;


        public Form2(string username,Form1 from1)
        {
            USER = username;
            this.from1 = from1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            txtypass = new TextBox();
            txtypass.Size = new Size(200, 50);
            txtypass.Location = new Point(this.ClientRectangle.Width / 2 - 100, this.ClientRectangle.Height / 2 - 80);
            txtypass.Text = "";
            txtypass.PasswordChar = '*';
            this.Controls.Add(txtypass);

           
            btnOK = new Button();
            btnOK.Size = new Size(50, 30);
            btnOK.Text = "OK";
            btnOK.Location = new Point(this.ClientRectangle.Width / 2 - 25, this.ClientRectangle.Height / 2 - 15);
            btnOK.Click += new EventHandler(btnOK_Click);
            this.Controls.Add(btnOK);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StreamReader sr = new
            StreamReader(@"D:\Ognjen Radojkovic\zadack (skocko skocko tlef tlef)\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\login.txt");
            string red;
            string pass;
            bool ima = false;
            while (!sr.EndOfStream)
            {
                red = sr.ReadLine();
                if (red == USER)
                {
                    ima = true;
                    break;
                }
            }
            if (ima)
            {
                pass = sr.ReadLine();
                if (pass == txtypass.Text)
                {
                    Form1 from1 = new Form1();
                    from1.login = true;
                    MessageBox.Show("RETARD ALERT"+" " + USER);
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Whomp Whomp 🙄. Wrong password idiot. JK I ♥ u just enter ur password again🥰");
                    txtypass.Text = "";
                    txtypass.Focus();
                }
            }

        }
    }
}
