using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMobileShop.Entity
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(15)]
        public string BrandName { get; set; }
    }
}
