using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Core.Entities;
using SampleApp.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        // GET: api/<SalesOrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SalesOrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SalesOrderController>
        [HttpPost]
        [ProducesResponseType(typeof(SalesOrderResponseDTOContainer), 200)]
        public SalesOrderResponseDTOContainer Post([FromBody] SalesOrderHeader salesOrderHeader)
        {
            return new SalesOrderResponseDTOContainer();
        }

        
        // PUT api/<SalesOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalesOrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
