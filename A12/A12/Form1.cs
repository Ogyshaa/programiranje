using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A12
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection();
        SqlCommand komanda;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            konekcija.ConnectionString = "Data Source=-NEMANJA-\\SQLEXPRESS;Initial Catalog=fudbalski_stadioniA12;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuniC();
            PopuniL();
        }

        void PopuniC()
        {
            string sql = "select grad, gradid from grad";
            konekcija.Open();
            komanda = new SqlCommand(sql, konekcija);
            SqlDataReader citac = komanda.ExecuteReader();
            dt = new DataTable();
            dt.Load(citac);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "grad";
            comboBox1.ValueMember = "gradid";
            konekcija.Close();
        }

        void PopuniL()
        {
            listView1.Items.Clear();
            konekcija.Open();
            string sql = "select stadionid, naziv, adresa, kapacitet, brulaza, grad from stadion s" +
                " join grad g on g.gradid=s.gradid";
            komanda = new SqlCommand(sql, konekcija);
            SqlDataReader citac = komanda.ExecuteReader();
            while (citac.Read())
            {
                ListViewItem red = new ListViewItem();
                red.Text = citac.GetValue(0).ToString();
                for (int i = 1; i < 6; i++)
                {
                    red.SubItems.Add(citac.GetValue(i).ToString());
                }
                listView1.Items.Add(red);
            }
            konekcija.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem red = listView1.SelectedItems[0];
                textBox1.Text = red.Text;
                textBox2.Text = red.SubItems[1].Text;
                textBox3.Text = red.SubItems[2].Text;
                numericUpDown1.Value = Convert.ToDecimal(red.SubItems[3].Text);
                numericUpDown2.Value = Convert.ToDecimal(red.SubItems[4].Text);
                comboBox1.Text = red.SubItems[5].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pretraga pret = new Pretraga();
            DialogResult rez = pret.ShowDialog();
            if (rez == DialogResult.OK) 
            {
                if (pret.DrzavaNaziv != "")
                {
                    konekcija.Open();
                    string sql = "select stadionid, s.naziv, adresa, kapacitet, brulaza, grad from stadion s" +
                         " join grad g on g.gradid=s.gradid join drzava d on d.drzavaid=g.drzavaid" +
                         " where d.naziv='" + pret.DrzavaNaziv.ToString()+"'";
                    listView1.Items.Clear();
                    komanda = new SqlCommand(sql, konekcija);
                    SqlDataReader citac = komanda.ExecuteReader();
                    while (citac.Read())
                    {
                        ListViewItem red = new ListViewItem();
                        red.Text = citac.GetValue(0).ToString();
                        for (int i = 1; i < 6; i++)
                        {
                            red.SubItems.Add(citac.GetValue(i).ToString());
                        }
                        listView1.Items.Add(red);
                    }
                    konekcija.Close();
                }
                else
                {
                    konekcija.Close();
                    PopuniL();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            konekcija.Open();
            string sql = "update stadion set naziv=@naziv, adresa=@adresa, kapacitet=@kapacitet," +
                " brulaza=@brulaza, gradid=@gradid where stadionid=" + textBox1.Text;
            komanda = new SqlCommand (sql, konekcija);
            komanda.Parameters.AddWithValue("@naziv", textBox2.Text);
            komanda.Parameters.AddWithValue("@adresa", textBox3.Text);
            komanda.Parameters.AddWithValue("@kapacitet", numericUpDown1.Value);
            komanda.Parameters.AddWithValue("@brulaza", numericUpDown2.Value);
            komanda.Parameters.AddWithValue("@gradid", comboBox1.SelectedValue);
            int n = komanda.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Uspesna promena!");
                konekcija.Close();
                PopuniL();
            }
            else
            {
                konekcija.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            forma.ShowDialog();
        }
    }
}
