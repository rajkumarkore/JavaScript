using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO.Net_Joins
{
    class Program
    {
        static SqlConnection con = null;
        static void Main(string[] args)
        {
            Connecting();
            Inner();
            Self();
            OuterLeft();
            OuterRight();
            OuterFull();

            Console.ReadKey();
        }
        public static void Connecting()
        {
            try
            {
                string constring = "data source = WIN-PC\\SQLEXPRESS; database=Om; integrated security=true";
                con = new SqlConnection(constring);

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Inner()
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM PERSON P INNER JOIN ADDRESS A ON P.PersonID = A.PERSONID", con);
                SqlDataReader sdr = cm.ExecuteReader();
                Console.WriteLine("\nInner");
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr.GetName(i) + "\t");
                }
                Console.WriteLine("\n===============================================================");
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Console.Write(sdr[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===============================================================");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }

        }

        public static void Self()
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM PERSON P INNER JOIN ADDRESS A ON P.PersonID = A.PERSONID", con);
                SqlDataReader sdr = cm.ExecuteReader();
                Console.WriteLine("\nSelf");
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr.GetName(i) + "\t");
                }
                Console.WriteLine("\n===============================================================");
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Console.Write(sdr[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===============================================================");

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public static void OuterLeft()
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM PERSON P LEFT OUTER JOIN ADDRESS A ON P.PersonID = A.PERSONID ", con);
                SqlDataReader sdr = cm.ExecuteReader();
                Console.WriteLine("\nLeftOuter");
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr.GetName(i) + "\t");
                }
                Console.WriteLine("\n===============================================================");
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Console.Write(sdr[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===============================================================");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public static void OuterRight()
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM PERSON P RIGHT OUTER JOIN ADDRESS A ON P.PersonID = A.PERSONID;", con);
                SqlDataReader sdr = cm.ExecuteReader();
                Console.WriteLine("\nRightOuter");
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr.GetName(i) + "\t");
                }
                Console.WriteLine("\n===============================================================");
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Console.Write(sdr[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===============================================================");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        public static void OuterFull()
        {
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM PERSON P FULL OUTER JOIN ADDRESS A ON P.PersonID = A.PERSONID", con);
                SqlDataReader sdr = cm.ExecuteReader();
                Console.WriteLine("\nFulllOuter");
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    Console.Write(sdr.GetName(i) + "\t");
                }
                Console.WriteLine("\n===============================================================");
                while (sdr.Read())
                {
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        Console.Write(sdr[i] + "\t");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("===============================================================");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}