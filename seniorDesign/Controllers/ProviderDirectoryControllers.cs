using System.Web.Mvc;

namespace MyTecBits_Bootstrap_Empty_MVC.Controllers
{
    public class DirectoryController : Controller
    {
        public ActionResult Index()
        { 
            return View("Index");
        }
        public ActionResult Map()
        {
            return View("Map");
        }
        public ActionResult List()
        {
            return View("List");
        }
        public ActionResult AdminMain()
        {
            return View("AdminMain");
        }
        public ActionResult Admin()
        {
            return View("Admin");
        }
        public ActionResult ApproveAdmin()
        {
            return View("ApproveAdmin");
        }
        public ActionResult Add()
        {
            return View("Add");
        }
        public ActionResult ApproveEditAdmin()
        {
            return View("ApproveEditAdmin");
        }
        public ActionResult Comments()
        {
            return View("Comments");
        }
        public ActionResult DeleteAdmin()
        {
            return View("DeleteAdmin");
        }
        public ActionResult Delete()
        {
            return View("Delete");
        }
        public ActionResult DeleteEditAdmin()
        {
            return View("DeleteEditAdmin");
        }
        public ActionResult Display()
        {
            return View("Display");
        }
        public ActionResult EditAdmin()
        {
            return View("EditAdmin");
        }
        public ActionResult Edit()
        {
            return View("Edit");
        }
        public ActionResult ShowAll()
        {
            return View("ShowAll");
        }
    }
}
