using System.ComponentModel.DataAnnotations;

namespace WebApplication_2207B2.Models
{
    public class std
    {
        [Required]
        [StringLength(10,MinimumLength = 3 ,ErrorMessage = "Username Should be atleast 3 or 10 letters" )]
        [Display(Name = "Username")]
        public string name { get; set; }
       
        [Required]
        public string email { get; set; }
        public int phoneno { get; set; }
        public string password { get; set; }

    }
}
