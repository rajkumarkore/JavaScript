using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework2.Models
{
    [Table("tblCategories")]  //table add here
    public class Catagory  //it is going to add nw class
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set;}
    }
}















//schema anotation is structerd form 
//model anotation is model way

