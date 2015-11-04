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
using SocialManager.Models;

namespace SocialManager.Controllers
{
    public class NoteTagsController : ApiController
    {
        private SocialManagerContext db = new SocialManagerContext();

        // GET: api/NoteTags
        public IQueryable<NoteTag> GetNoteTags()
        {
            return db.NoteTags;
        }

        // GET: api/NoteTags/5
        [ResponseType(typeof(NoteTag))]
        public IHttpActionResult GetNoteTag(int id)
        {
            NoteTag noteTag = db.NoteTags.Find(id);
            if (noteTag == null)
            {
                return NotFound();
            }

            return Ok(noteTag);
        }

        // PUT: api/NoteTags/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNoteTag(int id, NoteTag noteTag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != noteTag.Id)
            {
                return BadRequest();
            }

            db.Entry(noteTag).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoteTagExists(id))
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

        // POST: api/NoteTags
        [ResponseType(typeof(NoteTag))]
        public IHttpActionResult PostNoteTag(NoteTag noteTag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.NoteTags.Add(noteTag);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = noteTag.Id }, noteTag);
        }

        // DELETE: api/NoteTags/5
        [ResponseType(typeof(NoteTag))]
        public IHttpActionResult DeleteNoteTag(int id)
        {
            NoteTag noteTag = db.NoteTags.Find(id);
            if (noteTag == null)
            {
                return NotFound();
            }

            db.NoteTags.Remove(noteTag);
            db.SaveChanges();

            return Ok(noteTag);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NoteTagExists(int id)
        {
            return db.NoteTags.Count(e => e.Id == id) > 0;
        }
    }
}