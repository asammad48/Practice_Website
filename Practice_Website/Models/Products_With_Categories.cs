using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Products_With_Categories
    {
        public List<Product> products { get; set; }
        public List<Category> categories { get; set; }
        public List<Category_subCategory> category_Subs { get; set; }
        public List<SubCategory> subCategories { get; set; }
        public List<Variants> variants { get; set; }
        public List<Product_Variants> product_variants { get; set; }
        public List<SubSubCategory> subSubCategories { get; set; }
        public List<SubCategory_SubSubcategory> subCategory_Subs { get; set; }
        public Product Product { get; set; }
        public int Variant { get; set; }
        public List<Specification> specifications { get; set; }
    }
}
