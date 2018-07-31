﻿using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Create
    {
        private const string ConnectionString = "Data Source = WIN-PC\\SQLEXPRESS; database=Ramu; integrated security=true";

        static void Main(string[] args)
        {
            new Create().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
               
                // Creating Connection  
                con = new SqlConnection(ConnectionString);
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table student4(id int not null,   name varchar(100), email varchar(50), join_date date)", con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
               cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
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