using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Core.Models;

namespace SampleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestExampleController : ControllerBase
    {
        //// GET: api/<SalesOrderController>
        //[HttpGet]
        //public IEnumerable<TestClass> GetTestDetails()
        //{
        //    return new TestClass();
        //}

        //// GET api/<SalesOrderController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<SalesOrderController>
        [HttpPost]
        [ProducesResponseType(typeof(ResultExample), 200)]
        public ResultExample Post([FromBody] TestClass test)
        {
            ResultExample testResult = new ResultExample();    

            TestClass test2 = new TestClass();
            TestClassArray testClassArray = new TestClassArray();
            TestClassArray2 testClassArray2 = new TestClassArray2();
            
            test2.Name = test.Name;            
            
            foreach (var item in test.Related1)
            {
                foreach (var item2 in item.Related2)
                {
                    testClassArray2.id2 = item2.id2;
                }
                
                testClassArray.Related2.Add(testClassArray2); 
            }

            test2.Related1.Add(testClassArray);

            Console.WriteLine(test2);

            testResult.Message = "New Result added successfullly....";
            testResult.StatusCode = "201";

            return testResult;
        }


        //// PUT api/<SalesOrderController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SalesOrderController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
