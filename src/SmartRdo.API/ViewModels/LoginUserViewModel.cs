using System.ComponentModel.DataAnnotations;

namespace SmartRdo.API.ViewModels
{
    public class LoginUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
