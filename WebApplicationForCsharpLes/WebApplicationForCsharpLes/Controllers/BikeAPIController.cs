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
using WebApplicationForCsharpLes.Models;

namespace WebApplicationForCsharpLes.Controllers
{
    public class BikeAPIController : ApiController
    {
        private WebApplicationForCsharpLesContext db = new WebApplicationForCsharpLesContext();

        // GET: api/BikeAPI
        public IQueryable<Bike> GetBikes()
        {
            return db.Bikes;
        }

        // GET: api/BikeAPI/5
        [ResponseType(typeof(Bike))]
        public IHttpActionResult GetBike(int id)
        {
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return NotFound();
            }

            return Ok(bike);
        }

        // PUT: api/BikeAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBike(int id, Bike bike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bike.ID)
            {
                return BadRequest();
            }

            db.Entry(bike).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BikeExists(id))
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

        // POST: api/BikeAPI
        [ResponseType(typeof(Bike))]
        public IHttpActionResult PostBike(Bike bike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bikes.Add(bike);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bike.ID }, bike);
        }

        // DELETE: api/BikeAPI/5
        [ResponseType(typeof(Bike))]
        public IHttpActionResult DeleteBike(int id)
        {
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return NotFound();
            }

            db.Bikes.Remove(bike);
            db.SaveChanges();

            return Ok(bike);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BikeExists(int id)
        {
            return db.Bikes.Count(e => e.ID == id) > 0;
        }
    }
}