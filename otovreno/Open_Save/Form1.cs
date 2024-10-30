using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_Save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "All files|*.*|C# Files|*.cs";
            ofd1.FilterIndex = 1;
            ofd1.InitialDirectory = @"D:\Ognjen Radojkovic";
            ofd1.Multiselect = true;
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                foreach(string ime in ofd1.FileNames)
                {
                    lbFile.Items.Add(ime);
                }

            }
        }

        private void ofd1_FileOk(object sender, CancelEventArgs e)//okie dokie
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(sfd1.ShowDialog() == DialogResult.OK)
            {
                this.Text = sfd1.FileName;
            }
        }
    }
}
