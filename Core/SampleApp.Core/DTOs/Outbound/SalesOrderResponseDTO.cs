using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SampleApp.Core.DTOs
{
    public class SalesOrderResponseDTOContainer
    {
        [JsonPropertyName("ResponseDetails")]

        public SalesOrderResponseDTO ResponseDetails { get; set; }

    }

    public class SalesOrderResponseDTO
    {
        public string SalesOrderId { get; set; }
        public string Status { get; set; }
        public string ProcessRemarks { get; set; }        
    }
}
