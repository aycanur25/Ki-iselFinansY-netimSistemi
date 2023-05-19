using System.Data;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Toplamgelirigetir();
            Toplamgidergetir();
            Gidernumaragetir();
            Gelirnumaragetir();
            Gideri�lemgetir();
            Geliri�lemgetir();
            Gelirmaxmiktargetir();
            Gidermaxmiktargetir();
            Giderminmiktargetir();
            Gelirminmiktargetir();
            b�t�egetir();
            giderkategori();
            gelirkategori();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Gelirsayfas� Obj = new Gelirsayfas�();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Gidersayfas� Obj = new Gidersayfas�();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Gelirg�r�nt�lemesayfas� Obj = new Gelirg�r�nt�lemesayfas�();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Giderg�r�nt�lemesayfas� Obj = new Giderg�r�nt�lemesayfas�();
            Obj.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"");//nisa
        private void Toplamgelirigetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gelir = Convert.ToInt32(dt.Rows[0][0].ToString());
                gelirmiktar.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        int gelir, gider;
        private void Toplamgidergetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gider = Convert.ToInt32(dt.Rows[0][0].ToString());
                gidermiktar�.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void b�t�egetir()
        {
            double b�t = gelir - gider;
            b�t�e.Text = b�t + " TL";
        }
        private void gelirkategori()
        {
            try
            {
                con.Open();
                string �nnerQuery = "";//nisa
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(�nnerQuery, con);//nisa
                sda1.Fill(dt1);
                string Query = " " + dt1.Rows[0][0].ToString();//nisa
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gelirkategori1.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void giderkategori()
        {
            try
            {
                con.Open();
                string �nnerQuery = "";//nisa
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(�nnerQuery, con);//nisa
                sda1.Fill(dt1);
                string Query = " " + dt1.Rows[0][0].ToString();//nisa
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                giderkategori1.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Gidernumaragetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gidernumara.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Gelirnumaragetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gelirnumara.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Geliri�lemgetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                geliri�lemtarihi.Text = dt.Rows[0][0].ToString() + " TL";
                geliri�lemtarihi1.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Gideri�lemgetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gideri�lemtarihi.Text = dt.Rows[0][0].ToString() + " TL";
                gideri�lemtarihi1.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Gelirmaxmiktargetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                maxgelirmiktar�.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }
        }
        private void Gelirminmiktargetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                mingelirmiktar.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }
        }
        private void Gidermaxmiktargetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gidermaxmiktar.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Giderminmiktargetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                mingidermiktar.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Giri�sayfas� Obj = new Giri�sayfas�();
            Obj.Show();
            this.Hide();
        }
    }
}