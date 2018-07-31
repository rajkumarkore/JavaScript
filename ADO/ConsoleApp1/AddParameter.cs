using System;
using System.Data;
using System.Data.SqlClient;

class ParamDemo
{
    static void Main()
    {
        // conn and reader declared outside try
        // block for visibility in finally block
        SqlConnection conn = null;
        SqlDataReader reader = null;

        string inputCity = "India";
        try
        {
            // instantiate and open connection
            conn = new
                SqlConnection("data source = WIN-PC\\SQLEXPRESS; database=Ramu; integrated security=true");
            conn.Open();

            // don't ever do this
            // SqlCommand cmd = new SqlCommand(
            // "select * from Customers where city = '" + inputCity + "'";

            // 1. declare command object with parameter
            SqlCommand cmd = new SqlCommand(
                "select * from Student2 where name = @Name", conn);

            // 2. define parameters used in command object
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Name";
            param.Value = inputCity;

            // 3. add new parameter to command object
            cmd.Parameters.Add(param);

            // get data stream
            reader = cmd.ExecuteReader();

            // write each record
            while (reader.Read())
            {
                Console.WriteLine("{0}, {1}",
                    reader["CompanyName"],
                    reader["ContactName"]);
            }
        }
        finally
        {
            // close reader
            if (reader != null)
            {
                reader.Close();
            }

            // close connection
            if (conn != null)
            {
                conn.Close();
            }
            Console.Read();
        }
    }
}