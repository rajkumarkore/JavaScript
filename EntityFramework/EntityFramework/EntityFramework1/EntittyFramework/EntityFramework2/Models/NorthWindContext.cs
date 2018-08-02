using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EntityFramework2.Models
{
    public class NorthWindContext : DbContext
    {
        public NorthWindContext() //const created
               :base("name=NorthWindConnection")
        {

        }

        public DbSet<Catagory> CatagoriesTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }

    }
}