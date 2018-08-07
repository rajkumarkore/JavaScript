using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework2.Controllers;
using EntityFramework2.Models;

namespace EntityFramework2.Controllers
{
    public class CategoriesController : Controller
    {
        RamuEntities db = new RamuEntities();
        // GET: Categories
        public ActionResult Index()
        {
            return View(db.tblCategories.ToList());
        }
    }
}