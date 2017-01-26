using System.ComponentModel.DataAnnotations;

namespace angpluralmvcempty.Controllers
{
    public class StudentVm
    {
        [Required(ErrorMessage = "FirstName field is required" )]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email field is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }  
    }
}