using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class MakalelerController : Controller
    {
        BlogSitesiEntities DB = new BlogSitesiEntities();
        // GET: Makaleler
        public ActionResult MakaleListesiIndex()
        {
            return View();
        }

        public ActionResult KategoriListesiIndex()
        {
            return View();
        }

        //Model ile kategorileri listelemeyi partial'la yapıyoruz.
        public ActionResult KategoriListele()
        {
            // add view---> create as a partial view'i seçeriz.(hazır olarak listeleme ve model ve veritabanı da seçebiliriz. ama yapmadık. Bu nedenle modeli View ile gönderdik.)
            return View(DB.Kategoriler.ToList());
        }
    }
}