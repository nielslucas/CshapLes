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

            if(categoryName == "All") // This is just if you want to disable the filter
            {
                List<Artikels> allArtikels = new List<Artikels>();

                foreach(Artikels artikel in db.Artikels)
                {
                    allArtikels.Add(artikel);
                }

                return allArtikels;
            }

            Categories category = db.Categories.Where(c =>c.Name == categoryName).First();

            List<Artikels> artikels = new List<Artikels>();

            foreach (Artikels artikel in category.Artikels)
            {
                artikels.Add(artikel);
            }

            return artikels;
        }

        [HttpPost]
        [Route("api/ArtikelsOrderTemp")]
        public Artikels ArtikelsOrderTemp(JObject jsonData)
        {
            List<Artikel_Order> Artikels = new List<Artikel_Order>();
            dynamic json = jsonData;
            int id = json.id;

            Artikels artikel = db.Artikels.Where(a => a.ID == id).First();
            Artikel_Order tempArtikel = new Artikel_Order();
            tempArtikel.ArtikelID = id;
            tempArtikel.Amount = 1;

            HttpContext context = HttpContext.Current;

            if (context.Session["artikels"] != null)
            {
                Artikels = (List<Artikel_Order>)context.Session["artikels"];
                

                if (Artikels.Where(item => item.ArtikelID == tempArtikel.ArtikelID).Any())
                {
                    Artikel_Order containsArtikel = Artikels.Where(item => item.ArtikelID == tempArtikel.ArtikelID).First();
                    if (containsArtikel != null)
                    {
                        containsArtikel.Amount++;
                    }
                }
                else
                {
                    Artikels.Add(tempArtikel);
                }
                
            } else
            {
                Artikels.Add(tempArtikel);
            }

            

            context.Session["artikels"] = Artikels;

            return artikel;
        }

        [HttpPost]
        [Route("api/ArtikelsRemoveTemp")]
        public int ArtikelsRemoveTemp(JObject jsonData)
        {
            List<Artikel_Order> Artikels = new List<Artikel_Order>();
            dynamic json = jsonData;
            int indexNumber = json.indexNumber;

            HttpContext context = HttpContext.Current;

            Artikels = (List<Artikel_Order>)context.Session["artikels"];

            Artikels.RemoveAt(indexNumber);

            return indexNumber;

        }


    }
}