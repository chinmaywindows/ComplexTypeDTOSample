using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Core.Models;

namespace SampleApp.Core.DTOs
{
    public class TestClassDTO
    {   
            public string Name { get; set; }
        
            public List<TestClassArray> Related1 { get; set; }
        
    }
}
