using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ADO2
{
    class DisConnected
    {
        static void Main(String[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = \\DESKTOP - G0G1O13\\SQLEXPRESS; Initial Catalog = Testing; Integrated Security = True"))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("EmpId, EmpName from Emp", connection);
                    DataSet dsEmp = new DataSet();
                    DataTable dtEmp = dsEmp.Tables[0];
                    adapter.Fill(dtEmp);
                    foreach (DataRow row in dtEmp.Rows)
                    {
                        Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }


            }

            Console.ReadLine();
        }
    }
}