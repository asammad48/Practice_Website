using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Category_subCategory
    {
        [Key]
        public int SubCategory_SubSubcategoryID { get; set; }
       
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
  
        public int status { get; set; }
    }
}
