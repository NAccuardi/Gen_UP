using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using seniorDesign;
using seniorDesign.Models;

namespace MyTecBits_Bootstrap_Empty_MVC.Controllers
{
    public class ListController : Controller
    {
        public ActionResult List()
        {
            Entities1 entities = new Entities1();
            return View(from Main_Database_For_Directory in entities.Main_Database_For_Directory.Take(10) select Main_Database_For_Directory);
        }
    }
    


     
}
