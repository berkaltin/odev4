using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev4.Models;

namespace odev4.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/

        public List<Users> usersList = new List<Users>(){
                new Users(){id = 1, usernm = "name 1", loginnm = "lgn1", pwd = "1", date = DateTime.Now },
                new Users(){id = 2, usernm = "name 2", loginnm = "lgn2", pwd = "2", date = DateTime.Now },
                new Users(){id = 3, usernm = "name 3", loginnm = "lgn3", pwd = "3", date = DateTime.Now },
                new Users(){id = 4, usernm = "name 4", loginnm = "lgn4", pwd = "4", date = DateTime.Now },
                new Users(){id = 5, usernm = "name 5", loginnm = "lgn5", pwd = "5", date = DateTime.Now }
          };

        public ActionResult Users()
        {
            return View(this.usersList);
        }
	}
}