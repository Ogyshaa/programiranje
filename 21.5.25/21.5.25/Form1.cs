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

namespace _21._5._25
{
    public partial class Form1 : Form
    {
        private ListBox lb1;
        private ListBox lb2;
        private Button btnLoad;
        private Button btnTransfer;
        private Button btnManageOthers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb1 = new ListBox { Size = new Size(150, 200), Location = new Point(50, 50), SelectionMode = SelectionMode.MultiExtended };
            lb2 = new ListBox { Size = new Size(150, 200), Location = new Point(220, 50) };
            btnLoad = new Button { Text = "Učitaj Stavke", Size = new Size(100, 50), Location = new Point(50, 270) };
            btnTransfer = new Button { Text = "Prebaci Selekcije", Size = new Size(100, 50), Location = new Point(170, 270) };
            btnManageOthers = new Button { Text = "Uredi Preostale", Size = new Size(100, 50), Location = new Point(300, 270) };

            this.Controls.Add(lb1);
            this.Controls.Add(lb2);
            this.Controls.Add(btnLoad);
            this.Controls.Add(btnTransfer);
            this.Controls.Add(btnManageOthers);

            lb1.SelectedIndexChanged += new EventHandler(lb_SelectedIndexChanged);
            btnLoad.Click += new EventHandler(btnLoad_Click);
            btnTransfer.Click += new EventHandler(btnTransfer_Click);
            btnManageOthers.Click += new EventHandler(btnManageOthers_Click);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Ognjen Radojkovic\21.5.25\21.5.25\bin\Debug\abc.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                lb1.Items.Clear();
                lb1.Items.AddRange(lines);
            }
            else
            {
                MessageBox.Show("Fajl nije pronađen.");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var selectedItems = lb1.SelectedItems.Cast<string>().ToList();

            foreach (var item in selectedItems)
            {
                lb2.Items.Add(item);
                lb1.Items.Remove(item);
            }
        }
        
        private void btnManageOthers_Click(object sender, EventArgs e)
        {
            var remainingItems = lb1.Items.Cast<string>().ToList();
            Form2 form2 = new Form2(remainingItems);
            form2.ShowDialog();
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
