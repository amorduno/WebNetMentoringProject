using System.ComponentModel.DataAnnotations;

namespace SecurityApp.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
