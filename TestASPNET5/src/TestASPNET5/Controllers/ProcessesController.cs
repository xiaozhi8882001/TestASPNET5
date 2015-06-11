﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TestASPNET5.Models;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TestASPNET5.Controllers
{
    [Route("api/[controller]")]
    public class ProcessesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<ProcessInfo> Get()
        {
            var processList = Process.GetProcesses().OrderBy(p => p.ProcessName).ToList();
            return processList.Select(p => new ProcessInfo() { Name = p.ProcessName });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
