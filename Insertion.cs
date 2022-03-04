using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO2
{
    class Insertion
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Emp Id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the employee name");
                string name = Console.ReadLine();
                //Console.WriteLine("enter the salary");
               // int salary = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("enter the mobile number");
                //string phone = Console.ReadLine();
                SqlConnection connection = new SqlConnection("Data Source =DESKTOP-G0G1O13\\SQLEXPRESS; Initial Catalog = Testing; Integrated Security = true");
                    connection.Open();
                SqlCommand command = new SqlCommand("Insert into Emp(EmpID, EmpName)values(@EmpId,@EmpName)",connection);

                command.Parameters.AddWithValue("@empId", id);
                command.Parameters.AddWithValue("@empName", name);
                //command.Parameters.AddWithValue("@Phone", phone);
                command.ExecuteNonQuery();
                connection.Close();
                connection.Close();
                Console.WriteLine("Details saved successfully");
                Console.WriteLine("Hello.....!!");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           // Console.WriteLine("Details saved successfully");
            
        }
    }

}
