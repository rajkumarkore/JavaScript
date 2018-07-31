using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class ProgramInsertData
    {
        static void Main(string[] args)
        {
            new ProgramInsertData().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source = WIN-PC\\SQLEXPRESS; database=Ramu; integrated security=true");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student4(id, name, email, join_date) values('101', 'Modi', 'ronald@example.com', '1/12/2017')", con);
                SqlCommand cm1 = new SqlCommand("insert into student4(id, name, email, join_date) values('102', 'Kumaranna', 'nald@example.com', '12/12/2019')", con);
                SqlCommand cm2 = new SqlCommand("insert into student4(id, name, email, join_date) values('103', 'Modi', 'ronald@example.com', '1/12/2017')", con);
                SqlCommand cm3 = new SqlCommand("insert into student4(id, name, email, join_date) values('104', 'Modi', 'ronald@example.com', '1/12/2017')", con);
                SqlCommand cm4 = new SqlCommand("insert into student4(id, name, email, join_date) values('105', 'Modi', 'ronald@example.com', '1/12/2017')", con);
                SqlCommand cm5 = new SqlCommand("insert into student4(id, name, email, join_date) values('106', 'Modi', 'ronald@example.com', '1/12/2017')", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
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
            Console.ReadLine();
        }
    }
}