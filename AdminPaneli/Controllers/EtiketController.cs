using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli.Controllers
{
    public class EtiketController : Controller
    {
        BlogSitesiEntities DB = new BlogSitesiEntities();

        // GET: AdminPaneli/Etiket
        public ActionResult EtiketListesiIndex()
        {
            return View(DB.Etiketler.ToList());
        }
    }
}