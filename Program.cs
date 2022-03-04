using System;
using System.Data.SqlClient;

namespace ADO2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataReader reader = null;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source= DESKTOP-G0G1O13\\SQLEXPRESS; Initial Catalog = Testing;Integrated Security = true";
            connection.Open();
            SqlCommand command = new SqlCommand("Select EmpID, EmpName from Emp", connection);

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
            }
            reader.Close();
            connection.Close();
            Console.ReadKey();
        }
    }
    }

