using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EntityFramework2.Models;

namespace EntityFramework2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        RamuEntities db = new RamuEntities();
        public ActionResult Index(int id)
        {
            List<tblProduct> products = db.tblProducts.Where(x => x.Catagory_CategoryId == id).ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            return View(db.tblProducts.Single(x=>x.ProductId==id));
        }
    }
}