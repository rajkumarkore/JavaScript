using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EntityFramework2.Models
{
    [Table("tblProducts")]

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Catagory Catagory { get; set; }
    }
}




//primare key can access here foreign key











