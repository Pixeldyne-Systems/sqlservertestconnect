using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlServerTestConnect
{
	class Program
	{
        static readonly string query = "SELECT name FROM sys.databases";

        static void Main(string[] args)
		{
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["test"].ConnectionString);

            try
            {
                HasRows(sqlConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void HasRows(SqlConnection connection)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("Connection successful...");
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found, security issue?");
                }
                reader.Close();
            }
        }
    }
}
