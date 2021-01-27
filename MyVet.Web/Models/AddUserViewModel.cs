using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [MaxLength(100, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        [EmailAddress]
        public string Username { get; set; }

        //[Display(Name = "Document")]
        //[MaxLength(20, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        //[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        //public string Document { get; set; }

        //[Display(Name = "Prénom")]
        //[MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        //[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        //public string FirstName { get; set; }

        //[Display(Name = "Nom")]
        //[MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        //[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        //public string LastName { get; set; }

        //[MaxLength(100, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        //public string Address { get; set; }

        //[Display(Name = "Téléphone")]
        //[MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        //public string PhoneNumber { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères.")]
        public string Password { get; set; }

        [Display(Name = "Confirmation")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
