﻿using System;
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

namespace CSHARP_Opdracht_WebShop.Controllers
{
    public class CategoriesAPIController : ApiController
    {
        private ShopEntities db = new ShopEntities();

        // GET: api/CategoriesAPI
        public IQueryable<Categories> GetCategories()
        {
            return db.Categories;
        }

        // GET: api/CategoriesAPI/5
        [ResponseType(typeof(Categories))]
        public IHttpActionResult GetCategories(int id)
        {
            Categories categories = db.Categories.Find(id);
            if (categories == null)
            {
                return NotFound();
            }

            return Ok(categories);
        }

        // PUT: api/CategoriesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategories(int id, Categories categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categories.ID)
            {
                return BadRequest();
            }

            db.Entry(categories).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriesExists(id))
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

        // POST: api/CategoriesAPI
        [ResponseType(typeof(Categories))]
        public IHttpActionResult PostCategories(Categories categories)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Categories.Add(categories);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = categories.ID }, categories);
        }

        // DELETE: api/CategoriesAPI/5
        [ResponseType(typeof(Categories))]
        public IHttpActionResult DeleteCategories(int id)
        {
            Categories categories = db.Categories.Find(id);
            if (categories == null)
            {
                return NotFound();
            }

            db.Categories.Remove(categories);
            db.SaveChanges();

            return Ok(categories);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CategoriesExists(int id)
        {
            return db.Categories.Count(e => e.ID == id) > 0;
        }

        [Route("api/allCategories")]
        public IQueryable<Categories> allCategories()
        {
            return db.Categories;
        }
    }
}