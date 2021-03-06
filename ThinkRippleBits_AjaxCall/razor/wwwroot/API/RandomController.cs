﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace razor.Services
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RandomController : Controller
    {
        // GET: api/GetSample
        [HttpGet]
        public IEnumerable<string> GetSample()
        {
            return new string[] { "Sample string returned from the server." };
        }

        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "List of all items." };
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
