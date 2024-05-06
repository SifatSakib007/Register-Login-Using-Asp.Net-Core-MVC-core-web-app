using System.ComponentModel.DataAnnotations;

namespace JobFinding.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="User name is required.")]
        [Display(Name ="Email")]
        public string? Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Password is required.")]
        public string? Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
