﻿using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class DeleteStd
    {
        static void Main(string[] args)
        {
            new DeleteStd().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source = WIN-PC\\SQLEXPRESS; database=Ramu; integrated security=true");
                // writing sql query  
                SqlCommand cm = new SqlCommand("delete from student1 where id = '101'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
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