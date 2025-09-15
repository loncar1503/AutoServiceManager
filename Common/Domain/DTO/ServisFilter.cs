using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.DTO
{
    public class ServisFilter
    {
        public string? Query { get; set; }     
        public DateTime? DateFrom { get; set; } 
        public DateTime? DateTo { get; set; } 
    }
}
