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
using System.Xml;

namespace WinFormsApp1
{
    public partial class Girişsayfası : Form
    {
        public Girişsayfası()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Kayıtol Obj = new Kayıtol();
            Obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"");//nisa
        public static string Kişi;
        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanıcıadı.Text == "" || şifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre giriniz.");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();//nisa
                DateTable dt = new DateTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Kişi = kullanıcıadı.Text;
                    Dashboard Obj = new Dashboard();
                    Obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı ya da şifre.");
                    kullanıcıadı.Text = "";
                    şifre.Text = "";
                }
                con.Close();
            }

        }
    }
}
