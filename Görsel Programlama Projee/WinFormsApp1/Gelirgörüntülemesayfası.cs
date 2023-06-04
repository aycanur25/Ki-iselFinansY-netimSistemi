using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Gelirgörüntülemesayfası : Form
    {
        public Gelirgörüntülemesayfası()
        {
            InitializeComponent();
            gelirgörüntüleme();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
        private void gelirgörüntüleme()
        {
            con.Open();
            string Query = "select * from IncomeTbl";//nisa
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Görüntüleme.DataSource = ds.Tables[0];
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-05KF93P\SQLEXPRESS;Initial Catalog=FinanceDb;Integrated Security=True");//nisa
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gelirgörüntülemesayfası_Load(object sender, EventArgs e)
        {

        }

        private void Görüntüleme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Gelirsayfası Obj = new Gelirsayfası();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Gidersayfası Obj = new Gidersayfası();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Gidergörüntülemesayfası Obj = new Gidergörüntülemesayfası();
            Obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Girişsayfası Obj = new Girişsayfası();
            Obj.Show();
            this.Hide();
        }
    }
}
