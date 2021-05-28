using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Specification
    {
       
        public int SpecID { get; set; }
        public int ProductID { get; set; }
        public int VariantID { get; set; }
        public string SpecName { get; set; }
        public string SpecValue { get; set; }
    }
}
