using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework2.Models;

namespace EntityFramework2.Controllers
{
    public class NorthWindController : Controller
    {
        NorthWindContext db = new NorthWindContext();

        public ActionResult Index()
        {
            db.CatagoriesTable.ToList();
            db.ProductTable.ToList();
            return View();
        }
    }
}