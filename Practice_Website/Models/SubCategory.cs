
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{ 
    public class SubCategory
    {
      
        public int SubCategoryID { get; set; }
        
        public string SubCategoryName { get; set; }
        public int Status { get; set; }
    }
}
