using System;

public class Expence
{
	public Expence()
	{
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-P816U58\\MSSQLSERVER2;Initial Catalog=project;Integrated Security=True";// Veritabanı bağlantı dizesi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ExpCat, SUM(ExpAmt) AS TotalExpense FROM ExpTbl GROUP BY ExpCat"; // ExpTbl, tablo adı

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string category = reader["ExpCat"].ToString();
                    decimal totalExpense = Convert.ToDecimal(reader["TotalExpense"]);

                    Console.WriteLine("Category: " + category + ", Total Expense: " + totalExpense);
                }

                reader.Close();
            }

            Console.ReadLine();
        }
    }
}
