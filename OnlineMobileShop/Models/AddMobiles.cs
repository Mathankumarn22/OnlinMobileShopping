using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineMobileShop.Models
{
    public class AddMobiles
    {
       
        public int MobileID { get; set; }
        [Required]
    //    [MaxLength(10)]
  //      [DisplayName("Brand")]
//        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Please enter valid Brand")]

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        [DisplayName("Model")]
        [Required(ErrorMessage = "Please enter Mobile Model")]
        public string Model { get; set; }

        [DisplayName("Battery")]
        [Required(ErrorMessage = "Please enter Battery Capacity")]
        public int Battery { get; set; }
        [DisplayName("RAM")]
        [Required(ErrorMessage = "Please enter RAM Capacity")]
        public int RAM { get; set; }
        [DisplayName("ROM")]

        [Required(ErrorMessage = "Please enter ROM Capacity")]
        public int ROM { get; set; }
        [DisplayName("Price")]
        [Required(ErrorMessage = "Please enter Mobile Price")]
        public int Price { get; set; }
    }
}