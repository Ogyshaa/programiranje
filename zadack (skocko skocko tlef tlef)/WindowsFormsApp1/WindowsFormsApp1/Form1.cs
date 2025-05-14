using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool login = false;
        RadioButton radio1;
        RadioButton radio2;
        RadioButton radio3;
        ListBox lb;
        private void Form1_Load(object sender, EventArgs e)
        {
            radio1 = new RadioButton();
            radio1.Location = new Point(10, 10);
            radio1.Text = "BLU😂";
            radio1.Checked = true;
            radio1.Name = "radio1";
            this.BackColor = Color.AliceBlue;

            radio2 = new RadioButton();
            radio2.Location = new Point(10, 40);
            radio2.Text = "Led poisoning😮";
            radio2.Checked = false;
            radio2.Name = "radio2";
            this.BackColor = Color.IndianRed;

            radio3 = new RadioButton();
            radio3.Location = new Point(10, 70);
            radio3.Text = "Yelo😋";
            radio3.Checked = false;
            radio3.Name = "radio3";
            this.BackColor = Color.LemonChiffon;

            radio1.CheckedChanged += new EventHandler(radio1_CheckedChanged);
            radio2.CheckedChanged += new EventHandler(radio1_CheckedChanged);
            radio3.CheckedChanged += new EventHandler(radio1_CheckedChanged);

            lb = new ListBox();
            lb.Size = new Size(150, 200);
            lb.Location = new Point(this.ClientRectangle.Width / 2 - 75, this.ClientRectangle.Height / 2 - 100);
            lb.Items.Add("Pera Francuz");
            lb.Items.Add("Zoza");
            lb.Items.Add("Uciteljica Vesna");
            lb.Items.Add("Ana Ciganka");
            lb.SelectionMode = SelectionMode.One;
            lb.SelectedIndexChanged += new EventHandler(lb_SelectedIndexChanged);

            this.Controls.Add(radio1);
            this.Controls.Add(radio2);
            this.Controls.Add(radio3);
            this.Controls.Add(lb);
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Name == "radio1")
                this.BackColor = Color.AliceBlue;
            else if ((sender as RadioButton).Name == "radio2")
                this.BackColor = Color.IndianRed;
            else 
                this.BackColor = Color.LemonChiffon;
        }
        private string username = "";
        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            username = lb.SelectedItem.ToString();
            Form2 flom = new Form2(username,this);
            flom.StartPosition = FormStartPosition.CenterParent;
            flom.ShowDialog();
            if (login) 
            flom.ShowDialog();
        }
    }
}
