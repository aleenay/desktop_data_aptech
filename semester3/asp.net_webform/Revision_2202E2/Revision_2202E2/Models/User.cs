using System.ComponentModel.DataAnnotations;

namespace Revision_2202E2.Models
{
    public class User
    {
        [Required (ErrorMessage = "Name is empty")]
        public string name { get; set; }

        [Required(ErrorMessage = "Email is empty")]
        public string email { get; set; }
        public int phoneno{ get; set; }
        public string password { get; set; }               


    }
}
