using System;
using System.Data.SqlClient;

namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=Win-PC.\SQLEXPRESS;Initial Catalog=ComputerShop;Integrated Security=True");
            string query =
            @"CREATE TABLE dbo.Products
                (
                    ID int IDENTITY(1,1) NOT NULL,
                    Name nvarchar(50) NULL,
                    Price nvarchar(50) NULL,
                    Date datetime NULL,
                    CONSTRAINT pk_id PRIMARY KEY (ID)
                );";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}