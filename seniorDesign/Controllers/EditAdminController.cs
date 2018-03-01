using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace seniorDesign.Controllers
{
    public class EditAdminController : Controller
    {
        // GET: EditAdmin
        public ActionResult EditAdmin()
        {
            Entities entities = new Entities();
            return View(from Main_Database_For_Directory in entities.Main_Database_For_Directory.Take(10) select Main_Database_For_Directory);
        
        }
    }
}