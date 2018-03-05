using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seniorDesign.Controllers
{
    public class AdminMainController : Controller
    {
        // GET: AdminMain
        public ActionResult AdminMain()
        {
            Entities1 entities = new Entities1();
            return View(from Main_Database_For_Directory in entities.Main_Database_For_Directory.Take(10) select Main_Database_For_Directory);
        
        }
    }
}