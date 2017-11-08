using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using seniorDesign;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace seniorDesign.Controllers
{
    public class Main_Database_For_DirectoryController : Controller
    {
        private Entities db = new Entities();

        // GET: Main_Database_For_Directory
        public ActionResult Index()
        {
            return View(db.Main_Database_For_Directory.ToList());
        }

        // GET: Main_Database_For_Directory/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Main_Database_For_Directory main_Database_For_Directory = db.Main_Database_For_Directory.Find(id);
            if (main_Database_For_Directory == null)
            {
                return HttpNotFound();
            }
            return View(main_Database_For_Directory);
        }

        // GET: Main_Database_For_Directory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Main_Database_For_Directory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Organization,PhoneNumber,Email,StreetAddress,County,Country,PostalCode,ServicesOffered,TypeOfOrginization,InformationSource,ApprovedForDirectory")] Main_Database_For_Directory main_Database_For_Directory)
        {
            if (ModelState.IsValid)
            {
                db.Main_Database_For_Directory.Add(main_Database_For_Directory);
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = e.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join(" ; ", errorMessages);

                    // Combine the original exception message with the new one.
                    var exceptionMessage = string.Concat(e.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, e.EntityValidationErrors);
                }
                return RedirectToAction("Index");
            }

            return View(main_Database_For_Directory);
        }

        // GET: Main_Database_For_Directory/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Main_Database_For_Directory main_Database_For_Directory = db.Main_Database_For_Directory.Find(id);
            if (main_Database_For_Directory == null)
            {
                return HttpNotFound();
            }
            return View(main_Database_For_Directory);
        }

        // POST: Main_Database_For_Directory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Organization,PhoneNumber,Email,StreetAddress,County,Country,PostalCode,ServicesOffered,TypeOfOrginization,InformationSource,ApprovedForDirectory")] Main_Database_For_Directory main_Database_For_Directory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(main_Database_For_Directory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(main_Database_For_Directory);
        }

        // GET: Main_Database_For_Directory/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Main_Database_For_Directory main_Database_For_Directory = db.Main_Database_For_Directory.Find(id);
            if (main_Database_For_Directory == null)
            {
                return HttpNotFound();
            }
            return View(main_Database_For_Directory);
        }

        // POST: Main_Database_For_Directory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Main_Database_For_Directory main_Database_For_Directory = db.Main_Database_For_Directory.Find(id);
            db.Main_Database_For_Directory.Remove(main_Database_For_Directory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
