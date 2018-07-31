using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class DataReader
    {
        static void Main(string[] args)
        {
            new DataReader().GetData();
        }
        public void GetData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source = WIN-PC\\SQLEXPRESS; database=Ramu; integrated security=true");
                // writing sql query  
                SqlCommand cm = new SqlCommand("select * from student2", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
            Console.Read();
        }
    }
}