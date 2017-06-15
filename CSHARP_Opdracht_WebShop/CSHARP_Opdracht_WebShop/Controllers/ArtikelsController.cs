using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CSHARP_Opdracht_WebShop.Models;

namespace CSHARP_Opdracht_WebShop.Controllers
{
    public class ArtikelsController : Controller
    {
        private ShopEntities db = new ShopEntities();

        // GET: Artikels
        public ActionResult Index()
        {
            ViewBag.Categories = db.Categories.ToList();

            return View(db.Artikels.ToList());
        }

        // GET: Artikels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikels artikels = db.Artikels.Find(id);
            if (artikels == null)
            {
                return HttpNotFound();
            }
            return View(artikels);
        }

        // GET: Artikels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artikels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Price,Storage,Img")] Artikels artikels)
        {
            if (ModelState.IsValid)
            {
                db.Artikels.Add(artikels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artikels);
        }

        // GET: Artikels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikels artikels = db.Artikels.Find(id);
            if (artikels == null)
            {
                return HttpNotFound();
            }
            return View(artikels);
        }

        // POST: Artikels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Price,Storage,Img")] Artikels artikels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artikels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artikels);
        }

        // GET: Artikels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikels artikels = db.Artikels.Find(id);
            if (artikels == null)
            {
                return HttpNotFound();
            }
            return View(artikels);
        }

        // POST: Artikels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artikels artikels = db.Artikels.Find(id);
            db.Artikels.Remove(artikels);
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
