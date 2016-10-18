using odev4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace odev4.Controllers
{
    public class PanelController : Controller
    {
        //
        // GET: /Panel/

        public List<Product> productList = new List<Product>(){
                new Product(){id = 1, name = "pantalon", detail = "mavi", price = 123.00 },
                new Product(){id = 2, name = "bluz", detail = "siyah", price = 101.00 },
                new Product(){id = 3, name = "canta", detail = "sarı", price = 50.00 },
                new Product(){id = 4, name = "ayakkabı", detail = "yesil", price = 72.00 },
                new Product(){id = 5, name = "ceket", detail = "lacivert", price = 19.00 }
          };

        public ActionResult Panel()
        {
            if (Request.Cookies["mesaj_gosterildimi"] == null)
            {
                HttpCookie cookie = new HttpCookie("mesaj_gosterildimi", "evet");
                Response.Cookies.Add(cookie);
                ViewBag.ShowMessage = true;
            }

            ViewBag.name = Session["name"];

            return View(this.productList);
        }
	}
}