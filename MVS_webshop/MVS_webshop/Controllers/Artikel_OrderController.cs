using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVS_webshop.Models;

namespace MVS_webshop.Controllers
{
    public class Artikel_OrderController : Controller
    {
        private ShopEntities db = new ShopEntities();

        // GET: Artikel_Order
        public ActionResult Index()
        {
            var artikel_Order = db.Artikel_Order.Include(a => a.Artikel).Include(a => a.Order);
            return View(artikel_Order.ToList());
        }

        // GET: Artikel_Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikel_Order artikel_Order = db.Artikel_Order.Find(id);
            if (artikel_Order == null)
            {
                return HttpNotFound();
            }
            return View(artikel_Order);
        }

        // GET: Artikel_Order/Create
        public ActionResult Create()
        {
            ViewBag.ArtikelID = new SelectList(db.Artikels, "ID", "Name");
            ViewBag.OrderID = new SelectList(db.Orders, "ID", "ID");
            return View();
        }

        // POST: Artikel_Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtikelID,OrderID,Amount,Price")] Artikel_Order artikel_Order)
        {
            if (ModelState.IsValid)
            {
                db.Artikel_Order.Add(artikel_Order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtikelID = new SelectList(db.Artikels, "ID", "Name", artikel_Order.ArtikelID);
            ViewBag.OrderID = new SelectList(db.Orders, "ID", "ID", artikel_Order.OrderID);
            return View(artikel_Order);
        }

        // GET: Artikel_Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikel_Order artikel_Order = db.Artikel_Order.Find(id);
            if (artikel_Order == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtikelID = new SelectList(db.Artikels, "ID", "Name", artikel_Order.ArtikelID);
            ViewBag.OrderID = new SelectList(db.Orders, "ID", "ID", artikel_Order.OrderID);
            return View(artikel_Order);
        }

        // POST: Artikel_Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtikelID,OrderID,Amount,Price")] Artikel_Order artikel_Order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artikel_Order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtikelID = new SelectList(db.Artikels, "ID", "Name", artikel_Order.ArtikelID);
            ViewBag.OrderID = new SelectList(db.Orders, "ID", "ID", artikel_Order.OrderID);
            return View(artikel_Order);
        }

        // GET: Artikel_Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikel_Order artikel_Order = db.Artikel_Order.Find(id);
            if (artikel_Order == null)
            {
                return HttpNotFound();
            }
            return View(artikel_Order);
        }

        // POST: Artikel_Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artikel_Order artikel_Order = db.Artikel_Order.Find(id);
            db.Artikel_Order.Remove(artikel_Order);
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
