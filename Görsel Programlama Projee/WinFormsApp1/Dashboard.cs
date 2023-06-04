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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-05KF93P\SQLEXPRESS;Initial Catalog=FinanceDb;Integrated Security=True");
        private void Toplamgelirigetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTbl where IncUser = '" + Giriþsayfasý.Kiþi + "'", con);
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
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpUser = '" + Giriþsayfasý.Kiþi + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gider = Convert.ToInt32(dt.Rows[0][0].ToString());
                gidermiktarý.Text = dt.Rows[0][0].ToString();
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
                string ýnnerQuery = "select Max(IncAmt) from IncomeTbl";
                SqlDataAdapter sda1 = new SqlDataAdapter(ýnnerQuery, con);
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
                string ýnnerQuery = "select Max(ExpAmt) from ExpenseTbl ";//nisa
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(ýnnerQuery, con);//nisa
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
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Giriþsayfasý.Kiþi + "'", con);//nisa
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
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from IncomeTbl where IncUser='" + Giriþsayfasý.Kiþi + "'", con);//nisa
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
        private void Geliriþlemgetir()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from IncomeTbl where IncUser='" + Giriþsayfasý.Kiþi + "'", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                geliriþlemtarihi.Text = dt.Rows[0][0].ToString();
                geliriþlemtarihi1.Text = dt.Rows[0][0].ToString();
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
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser='" + Giriþsayfasý.Kiþi + "'", con);//nisa
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gideriþlemtarihi.Text = dt.Rows[0][0].ToString();
                gideriþlemtarihi1.Text = dt.Rows[0][0].ToString();
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
                SqlCommand cmd = new SqlCommand("SELECT MAX(IncAmt) FROM IncomeTbl WHERE IncUser = @Kiþi", con);
                cmd.Parameters.AddWithValue("@Kiþi", Giriþsayfasý.Kiþi);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    maxgelirmiktarý.Text = result.ToString() + " TL";
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
                cmd.Parameters.AddWithValue("@Kisi", Giriþsayfasý.Kiþi);
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
                cmd.Parameters.AddWithValue("@Kisi", Giriþsayfasý.Kiþi);
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
                cmd.Parameters.AddWithValue("@Kisi", Giriþsayfasý.Kiþi);
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
            Giriþsayfasý Obj = new Giriþsayfasý();
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