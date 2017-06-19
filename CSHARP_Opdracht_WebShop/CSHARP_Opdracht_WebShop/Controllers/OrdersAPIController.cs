using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CSHARP_Opdracht_WebShop.Models;
using Newtonsoft.Json.Linq;
using System.Web;

namespace CSHARP_Opdracht_WebShop.Controllers
{
    public class OrdersAPIController : ApiController
    {
        private ShopEntities db = new ShopEntities();

        // GET: api/OrdersAPI
        public IQueryable<Orders> GetOrders()
        {
            return db.Orders;
        }

        // GET: api/OrdersAPI/5
        [ResponseType(typeof(Orders))]
        public IHttpActionResult GetOrders(int id)
        {
            Orders orders = db.Orders.Find(id);
            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        // PUT: api/OrdersAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrders(int id, Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orders.ID)
            {
                return BadRequest();
            }

            db.Entry(orders).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/OrdersAPI
        [ResponseType(typeof(Orders))]
        public IHttpActionResult PostOrders(Orders orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(orders);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = orders.ID }, orders);
        }

        // DELETE: api/OrdersAPI/5
        [ResponseType(typeof(Orders))]
        public IHttpActionResult DeleteOrders(int id)
        {
            Orders orders = db.Orders.Find(id);
            if (orders == null)
            {
                return NotFound();
            }

            db.Orders.Remove(orders);
            db.SaveChanges();

            return Ok(orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrdersExists(int id)
        {
            return db.Orders.Count(e => e.ID == id) > 0;
        }

        [HttpPost]
        [ResponseType(typeof(Orders))]
        [Route("api/Orders/InsertOrderWithArticles")]
        public List<Artikel_Order> InsertOrderWithArticles(JObject jsonData)
        {
            List<Artikel_Order> Artikels = new List<Artikel_Order>();
            dynamic json = jsonData;
            int userID = json.userID;

            HttpContext context = HttpContext.Current;

            Artikels = (List<Artikel_Order>)context.Session["artikels"];

            Orders newOrder = new Orders();
            newOrder.CustomerID = userID;
            db.Orders.Add(newOrder);
            db.SaveChanges();

            foreach (Artikel_Order artikel in Artikels)
            {
                artikel.OrderID = newOrder.ID;
                newOrder.Artikel_Order.Add(artikel);
            }

            db.SaveChanges();

            context.Session["artikels"] = null;

            return Artikels;
            
        }
    }
}