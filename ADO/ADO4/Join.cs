using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;

namespace ADO4
{
    class Join
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            ds.Locale = CultureInfo.InvariantCulture;
            FillDataSet(ds);

            var orders = ds.Tables["SalesOrderHeader"].AsEnumerable();
            var details = ds.Tables["SalesOrderDetail"].AsEnumerable();

            var query =
                from order in orders
                join detail in details
                on order.Field<int>("SalesOrderID")
                equals detail.Field<int>("SalesOrderID") into ords
                select new
                {
                    CustomerID =
                        order.Field<int>("SalesOrderID"),
                    ords = ords.Count()
                };

            foreach (var order in query)
            {
                Console.WriteLine("CustomerID: {0}  Orders Count: {1}",
                    order.CustomerID,
                    order.ords);
            }
        }

        private static void FillDataSet(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}