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
        
        // POST api/<TestExampleController>
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

    }
}
