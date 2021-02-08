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
using PenaltyCalculationService.Models;

namespace PenaltyCalculationService.Controllers
{
    public class bookController : ApiController
    {
        private PenaltyCalculationEntities db = new PenaltyCalculationEntities();

        // GET: api/book
        public IQueryable<book_trans_details> Getbook_trans_details()
        {
            return db.book_trans_details;
        }

        // GET: api/book/5
        [ResponseType(typeof(book_trans_details))]
        public IHttpActionResult Getbook_trans_details(int id)
        {
            book_trans_details book_trans_details = db.book_trans_details.Find(id);
            if (book_trans_details == null)
            {
                return NotFound();
            }

            return Ok(book_trans_details);
        }
    }
}