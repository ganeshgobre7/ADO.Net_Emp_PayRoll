using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmpPayRoll
{
    class EmployeeRepo
    {
        public static string connectionString = @"Data Source=DESKTOP-04NE37L;Initial Catalog=Payroll_Service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        
        public void DBconnection()
        {
            connection.Open();
            if(connection.State==ConnectionState.Open)
            {
                Console.WriteLine("Connection has been Created Successfully");
            }
            else
            {
                Console.WriteLine("Connection is Not Established");
            }
            connection.Close();
        }

       
    }
}
