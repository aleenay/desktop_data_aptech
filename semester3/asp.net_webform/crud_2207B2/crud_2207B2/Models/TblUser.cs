using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace crud_2207B2.Models
{
    public partial class TblUser
    {

        public int Id { get; set; }

        [Required (ErrorMessage = "Email requird")]
        [EmailAddress]
        [Display (Name = "User Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is requird")]
        public string? Password { get; set; }
    }
}
