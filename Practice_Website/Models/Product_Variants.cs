using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Product_Variants
    {
      
        public int product_variant_ID { get; set; }
        
        public  int VariantID { get; set; }
         public  int ProductID { get; set; }
        public int status { get; set; }
        public int Var_Stock { get; set; }
        public decimal Var_Price { get; set; }
        public decimal Var_Discount { get; set; }
        public int Var_Reviews { get; set; }
    }
}
