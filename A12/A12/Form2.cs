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
    public partial class Form2 : Form
    {
        SqlConnection konekcija = new SqlConnection();
        SqlCommand komanda;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
            konekcija.ConnectionString = "Data Source=-NEMANJA-\\SQLEXPRESS;Initial Catalog=fudbalski_stadioniA12;Integrated Security=True";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            konekcija.Open();
            string sql = "select top 10 s.naziv as Naziv, count(u.datumigranja) as Broj" +
                " from stadion s join klub k on s.stadionid=k.stadionid join " +
                " utakmica u on k.klubid=u.domacinid" +
                " where year(u.datumigranja) = 2022" +
                " group by s.naziv";
            komanda = new SqlCommand(sql,konekcija);
            SqlDataReader citac = komanda.ExecuteReader();
            dt = new DataTable();
            dt.Load(citac);
            chart1.DataSource = dt;
            chart1.Series[0].YValueMembers = "Broj";
            chart1.Series[0].XValueMember = "Naziv";
            chart1.DataBind();
            konekcija.Close();
        }
    }
}
