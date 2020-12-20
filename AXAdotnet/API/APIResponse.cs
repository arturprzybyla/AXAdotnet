using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXAdotnet.API
{
    public class ApiResponse
    {
        public int count { get; set; }
        public int? next { get; set; }
        public int? previous { get; set; }
        public Film[] results { get; set; }

    }
}
