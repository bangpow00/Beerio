using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beerio.Models
{
    // The intention here is create a smart class to transparenetly
    // handle quantities, units, and measurement conversions
    public class Quantity
    {
        public string Value { get; set; }

        public string Units { get; set; }

    }
}
