using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string Document { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        public string Address { get; set; }

        [Display(Name = "Téléphone")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        public string PhoneNumber { get; set; }
    }
}
