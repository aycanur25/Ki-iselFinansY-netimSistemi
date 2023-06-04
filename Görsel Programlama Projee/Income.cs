using System;

public class Income
{
	public Income()
	{
        static void Main()
        {

            string connectionString = "Data Source=DESKTOP-P816U58\\MSSQLSERVER2;Initial Catalog=project;Integrated Security=True";// Veritabanı bağlantı dizesi

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IncCat, SUM(InAmt) AS TotalIncome FROM IncomeTbl GROUP BY IncCat"; // income, tablo adı

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string category = reader["IncCat"].ToString();
                    decimal totalIncome = Convert.ToDecimal(reader["TotalIncome"]);

                    Console.WriteLine("Category: " + category + ", Total Income: " + totalIncome);
                }

                reader.Close();
            }

            Console.ReadLine();



        }
    }
}
