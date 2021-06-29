using SampleApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Core.DTOs
{
    public class SalesOrderHeaderSalesReasonDTO
    {
     
        
        public int SalesOrderId { get; set; }
        
       
        public int SalesReasonId { get; set; }
        
        public DateTime ModifiedDate { get; set; }
       
    }
}
