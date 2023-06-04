using System.Data;
using System.Data.SqlClient;

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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-05KF93P\SQLEXPRESS;Initial Catalog=FinanceDb;Integrated Security=True");
        private void Toplamgelirigetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser = '" + Giri�sayfas�.Ki�i + "'", con);
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
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser = '" + Giri�sayfas�.Ki�i + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gider = Convert.ToInt32(dt.Rows[0][0].ToString());
                gidermiktar�.Text = dt.Rows[0][0].ToString();
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
                string �nnerQuery = "select Max(IncAmt) from IncomeTbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(�nnerQuery, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                string Query = "select IncCat from IncomeTbl where IncAmt='" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gelirkategori1.Text = dt.Rows[0][0].ToString();
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
                string �nnerQuery = "select Max(ExpAmt) from ExpenseTbl ";//nisa
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(�nnerQuery, con);//nisa
                sda1.Fill(dt1);
                string Query = " select ExpCat from ExpenseTbl where ExpAmt='" + dt1.Rows[0][0].ToString() + "'";//nisa
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                giderkategori1.Text = dt.Rows[0][0].ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Giri�sayfas�.Ki�i + "'", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gidernumara.Text = dt.Rows[0][0].ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from IncomeTbl where IncUser='" + Giri�sayfas�.Ki�i + "'", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gelirnumara.Text = dt.Rows[0][0].ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from IncomeTbl where IncUser='" + Giri�sayfas�.Ki�i + "'", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                geliri�lemtarihi.Text = dt.Rows[0][0].ToString();
                geliri�lemtarihi1.Text = dt.Rows[0][0].ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser='" + Giri�sayfas�.Ki�i + "'", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gideri�lemtarihi.Text = dt.Rows[0][0].ToString();
                gideri�lemtarihi1.Text = dt.Rows[0][0].ToString();
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
                SqlCommand cmd = new SqlCommand("SELECT MAX(IncAmt) FROM IncomeTbl WHERE IncUser = @Ki�i", con);
                cmd.Parameters.AddWithValue("@Ki�i", Giri�sayfas�.Ki�i);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    maxgelirmiktar�.Text = result.ToString() + " TL";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void Gelirminmiktargetir()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MIN(IncAmt) FROM IncomeTbl WHERE IncUser = @Kisi", con);
                cmd.Parameters.AddWithValue("@Kisi", Giri�sayfas�.Ki�i);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    mingelirmiktar.Text = result.ToString() + " TL";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }


        private void Gidermaxmiktargetir()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ExpAmt) FROM ExpenseTbl WHERE ExpUser = @Kisi", con);
                cmd.Parameters.AddWithValue("@Kisi", Giri�sayfas�.Ki�i);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    gidermaxmiktar.Text = result.ToString() + " TL";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
        }

        private void Giderminmiktargetir()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MIN(ExpAmt) FROM ExpenseTbl WHERE ExpUser = @Kisi", con);
                cmd.Parameters.AddWithValue("@Kisi", Giri�sayfas�.Ki�i);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    mingidermiktar.Text = result.ToString() + " TL";
                }
                con.Close();
            }
            catch (Exception ex)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mingelirmiktar_Click(object sender, EventArgs e)
        {

        }


        private void gelirnumara_Click(object sender, EventArgs e)
        {

        }
    }
}