using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Website.Models
{
    public class Product_Images
    {
        public int p_img_id { get; set; }
        public virtual int ProductID { get; set; }
        public string Images { get; set; }
    }
}
