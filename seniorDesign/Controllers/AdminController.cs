using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using seniorDesign;


namespace MyTecBits_Bootstrap_Empty_MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            Entities1 entities = new Entities1();
            return View(from Main_Database_For_Directory in entities.Main_Database_For_Directory.Take(10) select Main_Database_For_Directory);
        }
    }
    }
