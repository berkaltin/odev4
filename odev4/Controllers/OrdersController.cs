using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev4.Models;

namespace odev4.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        
        public List<Orders> ordersList = new List<Orders>(){
                new Orders(){id = 1, ordesnm = "Sipariş 1", productnm = "1.Ürün", producprice = 123.00, producpiece = 1, date = DateTime.Now},
                new Orders(){id = 2, ordesnm = "Sipariş 2", productnm = "2.Ürün", producprice = 101.00, producpiece = 3, date = DateTime.Now },
                new Orders(){id = 3, ordesnm = "Sipariş 3", productnm = "3.Ürün", producprice = 50.00, producpiece = 5, date = DateTime.Now },
                new Orders(){id = 4, ordesnm = "Sipariş 4", productnm = "4.Ürün", producprice = 72.00, producpiece = 7, date = DateTime.Now },
                new Orders(){id = 5, ordesnm = "Sipariş 5", productnm = "5.Ürün", producprice = 19.00, producpiece = 9, date = DateTime.Now }
          };

        public ActionResult Orders()
        {
            return View(this.ordersList);
        }
	}
}