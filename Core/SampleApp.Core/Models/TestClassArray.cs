using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
{
    public class TestClassArray
    {
        public TestClassArray()
        {
            Related2    = new List<TestClassArray2>();
        }
    
        public string id1 { get; set; }
        
        public List<TestClassArray2> Related2 { get; set; }
    }
}
