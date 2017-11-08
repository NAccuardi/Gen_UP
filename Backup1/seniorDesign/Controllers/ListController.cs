using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTecBits_Bootstrap_Empty_MVC.Controllers
{
    public class ListController : Controller
    {
        public ActionResult List()
        {
            return View();
        }
    }
    public class Scrapped_Data
    {
        public string Organization { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

    }


     
}
