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

namespace CSHARP_Opdracht_WebShop.Controllers
{
    public class ArtikelsAPIController : ApiController
    {
        private ShopEntities db = new ShopEntities();

        // GET: api/ArtikelsAPI
        public IQueryable<Artikels> GetArtikels()
        {
            return db.Artikels;
        }

        // GET: api/ArtikelsAPI/5
        [ResponseType(typeof(Artikels))]
        public IHttpActionResult GetArtikels(int id)
        {
            Artikels artikels = db.Artikels.Find(id);
            if (artikels == null)
            {
                return NotFound();
            }

            return Ok(artikels);
        }

        // PUT: api/ArtikelsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArtikels(int id, Artikels artikels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != artikels.ID)
            {
                return BadRequest();
            }

            db.Entry(artikels).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtikelsExists(id))
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

        // POST: api/ArtikelsAPI
        [ResponseType(typeof(Artikels))]
        public IHttpActionResult PostArtikels(Artikels artikels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Artikels.Add(artikels);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = artikels.ID }, artikels);
        }

        // DELETE: api/ArtikelsAPI/5
        [ResponseType(typeof(Artikels))]
        public IHttpActionResult DeleteArtikels(int id)
        {
            Artikels artikels = db.Artikels.Find(id);
            if (artikels == null)
            {
                return NotFound();
            }

            db.Artikels.Remove(artikels);
            db.SaveChanges();

            return Ok(artikels);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArtikelsExists(int id)
        {
            return db.Artikels.Count(e => e.ID == id) > 0;
        }

        [Route("api/ArtikelsOrderByPrice")]
        public IQueryable<Artikels> ArtikelOrderByPrive()
        {
            return db.Artikels.OrderBy(a => a.Price);
        }

        [HttpPost]
        [Route("api/ArtikelsByCategory")]
        public List<Artikels> ArtikelsByCategory(JObject jsonData)
        {
            dynamic json = jsonData;
            string categoryName = json.name;

            Categories category = db.Categories.Where(c =>c.Name == categoryName).First();

            List<Artikels> artikels = new List<Artikels>();

            foreach (Artikels artikel in category.Artikels)
            {
                artikels.Add(artikel);
            }

            return artikels;
        }
    }
}