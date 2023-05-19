using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Gelirsayfası : Form
    {
        public Gelirsayfası()
        {
            InitializeComponent();
            Toplamgelirigetir();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"");//nisa
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Clear()
        {
            gelirkaynağı.Text = "";
            miktar.Text = "";
            açıklama.Text = "";
            kategoriler.SelectedIndex = 0;
        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            if (gelirkaynağı.Text == "" || açıklama.Text == "" || miktar.Text == "" || kategoriler.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("");//bağlantılar sende nisaa
                    cmd.Parameters.AddWithValue("@", gelirkaynağı.Text);//gelirsayfası
                    cmd.Parameters.AddWithValue("@", açıklama.Text);//
                    cmd.Parameters.AddWithValue("@", miktar.Text);//
                    cmd.Parameters.AddWithValue("@", tarih.Value.Date);//
                    cmd.Parameters.AddWithValue("@", kategoriler.SelectedItem.ToString());//
                    cmd.Parameters.AddWithValue("@", Girişsayfası.Kişi);//
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gelir kaydedilmiştir.:)");
                    con.close();
                    Toplamgelirigetir();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Gidersayfası Obj = new Gidersayfası();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Gelirgörüntülemesayfası Obj = new Gelirgörüntülemesayfası();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Gidergörüntülemesayfası Obj = new Gidergörüntülemesayfası();
            Obj.Show();
            this.Hide();
        }
        private void Toplamgelirigetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //gelir = Convert.ToInt32(dt.Rows[0][0].ToString());
                toplamgelir1.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Girişsayfası Obj = new Girişsayfası();
            Obj.Show();
            this.Hide();
        }
    }
}
