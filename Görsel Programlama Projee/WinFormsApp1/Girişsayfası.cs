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
using System.Security.Policy;

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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-05KF93P\SQLEXPRESS;Initial Catalog=FinanceDb;Integrated Security=True");
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
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE UName = @KullaniciAdi AND UPass = @Sifre", con);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullanıcıadı.Text);
                cmd.Parameters.AddWithValue("@Sifre", şifre.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Kişi = kullanıcıadı.Text;
                    Dashboard obj = new Dashboard();
                    obj.Show();
                    this.Hide();
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
