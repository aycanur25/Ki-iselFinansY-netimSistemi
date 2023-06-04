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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-05KF93P\SQLEXPRESS;Initial Catalog=FinanceDb;Integrated Security=True");//nisa
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl(UName,UDob,UPhone,UPass,UAddress) VALUES(@UN,@UD,@UP,@UPA,@UA)",con);
                    cmd.Parameters.AddWithValue("@UN", kullanıcıadı.Text);//kullanıcıadı
                    cmd.Parameters.AddWithValue("@UD", doğumtarihi.Value.Date);//doğumtarihi
                    cmd.Parameters.AddWithValue("@UP", telefonnumarası.Text);//telefonnumarası
                    cmd.Parameters.AddWithValue("@UPA", şifre.Text);//şifre
                    cmd.Parameters.AddWithValue("@UA", adres.Text);//adres
                    MessageBox.Show("Kaydınız tamamlanmıştır.:)");
                    con.Close();
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
