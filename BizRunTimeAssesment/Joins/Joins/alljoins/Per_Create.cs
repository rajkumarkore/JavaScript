using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.Net
{
    class Emp_Create
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source = WIN - PC\\SQLEXPRESS; database = Employee; integrated security = true");
                SqlCommand query = new SqlCommand("create table employee(id int not null, name varchar(100), city varchar(100))", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing went wrong:" + e);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con = null;
                }
            }
            Console.ReadLine();
        }
    }
}
