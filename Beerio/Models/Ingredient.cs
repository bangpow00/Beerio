using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beerio.Models
{
    // The basic building block.  This class could be extended to
    // relate to inventory
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
