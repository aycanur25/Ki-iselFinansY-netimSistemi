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
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"");//nisa
        private void Clear()
        {
            kullanıcıadı.Text = "";
            şifre.Text = "";
            telefonnumarası.Text = "";
            adres.Text = "";

        }
        private void kayıtoll_Click(object sender, EventArgs e)
        {
            if (kullanıcıadı.Text == "" || şifre.Text == "" || telefonnumarası.Text == "" || adres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("");//bağlantılar sende nisaa
                    cmd.Parameters.AddWithValue("@", kullanıcıadı.Text);//kullanıcıadı
                    cmd.Parameters.AddWithValue("@", şifre.Text);//şifre
                    cmd.Parameters.AddWithValue("@", telefonnumarası.Text);//telefonnumarası
                    cmd.Parameters.AddWithValue("@", doğumtarihi.Value.Date);//doğumtarihi
                    cmd.Parameters.AddWithValue("@", adres.Text);//adres
                    MessageBox.Show("Kaydınız tamamlanmıştır.:)");
                    con.close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Girişsayfası Obj = new Girişsayfası();
            Obj.Show();
            this.Hide();
        }
    }
}
