using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Core.Models
{
    public class TestClass
    {
        public TestClass()
        {
            Related1 = new List<TestClassArray>();
        }

        public string Name { get; set; }

        public List<TestClassArray> Related1 { get; set; }
    }
}
