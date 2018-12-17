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
using HE_SchlumbergerWebAPI.Models;

namespace HE_SchlumbergerWebAPI.Controllers
{
    public class HotelsController : ApiController
    {
        private HackerEarthDBEntities1 db = new HackerEarthDBEntities1();

        // GET: api/Hotels
        public IQueryable<arth_hotels> Getarth_hotels()
        {
            return db.arth_hotels;
        }

        // GET: api/Hotels/5
        [ResponseType(typeof(arth_hotels))]
        public IHttpActionResult Getarth_hotels(int id)
        {
            arth_hotels arth_hotels = db.arth_hotels.Find(id);
            if (arth_hotels == null)
            {
                return NotFound();
            }

            return Ok(arth_hotels);
        }

        // PUT: api/Hotels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putarth_hotels(int id, arth_hotels arth_hotels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != arth_hotels.id)
            {
                return BadRequest();
            }

            db.Entry(arth_hotels).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!arth_hotelsExists(id))
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

        // POST: api/Hotels
        [ResponseType(typeof(arth_hotels))]
        public IHttpActionResult Postarth_hotels(arth_hotels arth_hotels)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.arth_hotels.Add(arth_hotels);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = arth_hotels.id }, arth_hotels);
        }

        // DELETE: api/Hotels/5
        [ResponseType(typeof(arth_hotels))]
        public IHttpActionResult Deletearth_hotels(int id)
        {
            arth_hotels arth_hotels = db.arth_hotels.Find(id);
            if (arth_hotels == null)
            {
                return NotFound();
            }

            db.arth_hotels.Remove(arth_hotels);
            db.SaveChanges();

            return Ok(arth_hotels);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool arth_hotelsExists(int id)
        {
            return db.arth_hotels.Count(e => e.id == id) > 0;
        }
    }
}