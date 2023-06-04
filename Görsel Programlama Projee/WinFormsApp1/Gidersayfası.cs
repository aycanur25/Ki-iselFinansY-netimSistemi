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

namespace WinFormsApp1
{
    public partial class Gidersayfası : Form
    {
        public Gidersayfası()
        {
            InitializeComponent();
            Toplamgidergetir();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Gelirsayfası Obj = new Gelirsayfası();
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-05KF93P\SQLEXPRESS;Initial Catalog=FinanceDb;Integrated Security=True");
        private void Clear()
        {
            giderkaynağı.Text = "";
            miktar1.Text = "";
            açıklama1.Text = "";
            kategoriler1.SelectedIndex = 0;
        }
        private void kaydet1_Click(object sender, EventArgs e)
        {
            if (giderkaynağı.Text == "" || açıklama1.Text == "" || miktar1.Text == "" || kategoriler1.SelectedIndex == -1)
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl(ExpName,ExpAmt,ExpCat,ExpDate,ExpDesc,ExpUser) values(@EN,@EA,@EC,@ED,@EDe,@EU)", con);
                    cmd.Parameters.AddWithValue("@EN", giderkaynağı.Text);//gidersayfası
                    cmd.Parameters.AddWithValue("@EA", miktar1.Text);//
                    cmd.Parameters.AddWithValue("@EDe", açıklama1.Text);//
                    cmd.Parameters.AddWithValue("@ED", tarih1.Value.Date);//
                    cmd.Parameters.AddWithValue("@EC", kategoriler1.SelectedItem.ToString());//
                    cmd.Parameters.AddWithValue("@EU", Girişsayfası.Kişi);//
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gider kaydedilmiştir.:)");
                    con.Close();
                    Toplamgidergetir();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Toplamgidergetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(ExpAmt) FROM ExpenseTbl WHERE ExpUser = @Kişi", con);
                sda.SelectCommand.Parameters.AddWithValue("@Kişi", Girişsayfası.Kişi);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    toplamgider.Text = dt.Rows[0][0].ToString() + " TL";
                }
                con.Close();
            }
            catch (Exception ex)
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
