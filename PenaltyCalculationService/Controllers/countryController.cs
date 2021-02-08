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
using Microsoft.AspNetCore.Cors;
using PenaltyCalculationService.Models;

namespace PenaltyCalculationService.Controllers
{
    public class countryController : ApiController
    {
        private PenaltyCalculationEntities db = new PenaltyCalculationEntities();

        // GET: api/country
        public IQueryable<country> Getcountries()
        {
            return db.countries;
        }

        // GET: api/country/5
        [ResponseType(typeof(country))]
        public IHttpActionResult Getcountry(int id)
        {
            country country = db.countries.Find(id);
            if (country == null)
            {
                return NotFound();
            }

            return Ok(country);
        }

    }
}