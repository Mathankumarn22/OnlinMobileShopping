using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMobileShop.Models
{
    public class Brand
    {
        public int BrandID { get; set; }
        [Required]
        public string BrandName { get; set; }
    }
}