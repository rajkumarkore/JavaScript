﻿using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Retrive
    {
        static void Main(string[] args)
        {
            new Retrive().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source = WIN-PC\\SQLEXPRESS; database=Ramu; integrated security=true");
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student3", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]); // Displaying Record  
                }
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