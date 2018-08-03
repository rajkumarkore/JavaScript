﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Self_Join
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = WIN - PC\\SQLEXPRESS; database = Employee; integrated security = true");
                SqlCommand query = new SqlCommand("select e2.name from Emp_Salary e1, Emp_Salary e2 where e1.salary = e2.salary and e1.name ='om'; ", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();
                int count = data.FieldCount;
                while (data.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(data[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing went wrong:" + e);
            }
            finally
            {
                con.Close();
            }
            Console.Read();
        }
    }
}
