using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Mot de passe")]
        [MinLength(6)]
        public string Password { get; set; }

        [Display(Name = "Se souvenir de moi ?")]
        public bool RememberMe { get; set; }
    }
}
