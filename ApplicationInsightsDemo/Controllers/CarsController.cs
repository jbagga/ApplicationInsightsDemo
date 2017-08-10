﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationInsightsDemo.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private AppDbContext _db;

        public CarsController(AppDbContext db)
        {
            _db = db;  
        }

        // GET api/cars
        [HttpGet]
        public IList<Car> Get()
        {
            return _db.Cars.ToList();
        }

        // GET api/cars/5
        [HttpGet("{id}")]
        public async Task<Car> Get(int id)
        {
            var car = await _db.Cars.FindAsync(id);
            return car;
        }

        // POST api/cars
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
