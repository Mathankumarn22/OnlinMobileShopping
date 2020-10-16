
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace OnlineMobileShop.Entity
{
    public class Account
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public long PhoneNumber { get; set; }

        [Required]
        public string Gender { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(35)]
        [Required]
        public string MailID { get; set; }

        [MaxLength(15)]
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }

       
    }
   
}
