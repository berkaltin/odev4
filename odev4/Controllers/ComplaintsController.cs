using odev4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odev4.Controllers
{
    public class ComplaintsController : Controller
    {
        //
        // GET: /Complaints/

        public List<Complaints> complaintsList = new List<Complaints>(){
                new Complaints(){id = 1, complaintstitle = "Şikayet 1", complaintsSubject = "Şikayet Konu 1", complaintWhy = "Şikayet Nedeni 1", date = DateTime.Now },
                new Complaints(){id = 2, complaintstitle = "Şikayet 2", complaintsSubject = "Şikayet Konu 2", complaintWhy = "Şikayet Nedeni 2", date = DateTime.Now },
                new Complaints(){id = 3, complaintstitle = "Şikayet 3", complaintsSubject = "Şikayet Konu 3", complaintWhy = "Şikayet Nedeni 3", date = DateTime.Now },
                new Complaints(){id = 4, complaintstitle = "Şikayet 4", complaintsSubject = "Şikayet Konu 4", complaintWhy = "Şikayet Nedeni 4", date = DateTime.Now },
                new Complaints(){id = 5, complaintstitle = "Şikayet 5", complaintsSubject = "Şikayet Konu 5", complaintWhy = "Şikayet Nedeni 5", date = DateTime.Now }
          };

        public ActionResult Complaints()
        {
            return View(this.complaintsList);
        }
	}
}