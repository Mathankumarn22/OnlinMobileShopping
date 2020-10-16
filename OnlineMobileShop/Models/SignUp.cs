using OnlineMobileShop.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace OnlineMobileShop.Models
{
    public class SignUp
    {
     
        [Required]
        [MaxLength(30)]
        [DisplayName("Name")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "Please enter valid name")]
        public string Name { get; set; }

        [DisplayName("Mobile Number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        [RegularExpression(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}", ErrorMessage = "Please enter your number")]
        public long PhoneNumber { get; set; }

        [DisplayName("Gender")]
        [Required]
        [EnumDataType(typeof(Gender),ErrorMessage ="Please Enter the Gender")]
        public Gender Gender { get; set; }

        [DisplayName("Mail ID")]
        [MaxLength(35)]
        [Required(ErrorMessage = "Please enter your mail")]
        [EmailAddress(ErrorMessage = "Please enter valid mail")]
        public string MailID { get; set; }

        [DisplayName("Password")]
        [MaxLength(15)]
        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$", ErrorMessage = "Please enter valid password like uppercase,lowecase,symbol and number")]
        [MinLength(8, ErrorMessage = "Password should atleast contain 8 characters")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Compare("Password",ErrorMessage ="Password does not match")]
        [Required(ErrorMessage = "Re-Enter Your password")]
        [RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$", ErrorMessage = "Please Re-Enter Your password")]
        [MinLength(8, ErrorMessage = "Password should atleast contain 8 characters")]
        public string ConfirmPassword { get; set; }
    }
    public enum Gender
    {
        Male = 1,
        Female,
        Other
    }
}
