using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using seniorDesign;

namespace MyTecBits_Bootstrap_Empty_MVC.Controllers
{
    public class AdminPageController : Controller
    {
        // GET: AdminPage
        public ActionResult AdminPage()
        {
            Entities entities = new Entities();
            return View(from Main_Database_For_Directory in entities.Main_Database_For_Directory.Take(10) select Main_Database_For_Directory);
        }
    }
}