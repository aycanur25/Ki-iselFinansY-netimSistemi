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
            Gideriþlemgetir();
            Geliriþlemgetir();
            Gelirmaxmiktargetir();
            Gidermaxmiktargetir();
            Giderminmiktargetir();
            Gelirminmiktargetir();
            bütçegetir();
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
            Gelirsayfasý Obj = new Gelirsayfasý();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Gidersayfasý Obj = new Gidersayfasý();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Gelirgörüntülemesayfasý Obj = new Gelirgörüntülemesayfasý();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Gidergörüntülemesayfasý Obj = new Gidergörüntülemesayfasý();
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
                gidermiktarý.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void bütçegetir()
        {
            double büt = gelir - gider;
            bütçe.Text = büt + " TL";
        }
        private void gelirkategori()
        {
            try
            {
                con.Open();
                string ýnnerQuery = "";//nisa
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(ýnnerQuery, con);//nisa
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
                string ýnnerQuery = "";//nisa
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(ýnnerQuery, con);//nisa
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
        private void Geliriþlemgetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                geliriþlemtarihi.Text = dt.Rows[0][0].ToString() + " TL";
                geliriþlemtarihi1.Text = dt.Rows[0][0].ToString() + " TL";
                con.Close();
            }
            catch (Exception Ex)
            {
                con.Close();
            }

        }
        private void Gideriþlemgetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gideriþlemtarihi.Text = dt.Rows[0][0].ToString() + " TL";
                gideriþlemtarihi1.Text = dt.Rows[0][0].ToString() + " TL";
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
                maxgelirmiktarý.Text = dt.Rows[0][0].ToString() + " TL";
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
            Giriþsayfasý Obj = new Giriþsayfasý();
            Obj.Show();
            this.Hide();
        }
    }
}