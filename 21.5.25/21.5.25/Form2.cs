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
    public partial class Form2 : Form
    {
        private ListBox lb;
        private List<string> remainingItems;

        public Form2(List<string> items)
        {
            InitializeComponent();
            remainingItems = items;
            InitializeUI();
        }

        private void InitializeUI()
        {
            
            this.Size = new Size(300, 400);

            lb = new ListBox { Size = new Size(250, 300), Location = new Point(20, 20), SelectionMode = SelectionMode.One };
            lb.Items.AddRange(remainingItems.ToArray());
            lb.DoubleClick += Lb_DoubleClick;

            Button btnSave = new Button { Text = "Sacuvaj Promene", Size = new Size(100, 50), Location = new Point(100, 330) };
            btnSave.Click += BtnSave_Click;

            this.Controls.Add(lb);
            this.Controls.Add(btnSave);
        }

        private void Lb_DoubleClick(object sender, EventArgs e)
        {
            if (lb.SelectedItem != null)
            {
                lb.Items.Remove(lb.SelectedItem);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"D:\Ognjen Radojkovic\21.5.25\21.5.25\bin\Debug\abc.txt", GetAllItems());
            this.Close();
        }

        private List<string> GetAllItems()
        {
            List<string> items = new List<string>();
            foreach (var item in lb.Items)
            {
                items.Add(item.ToString());
            }
            return items;
        }
    }
}
