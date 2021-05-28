using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
       
        public int SubSubCategoryID { get; set; }
    }
}
