using System.Collections.Generic;
using etech.entity;

namespace etech.webui.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}