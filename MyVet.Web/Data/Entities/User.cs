using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Document")]
        [MaxLength(30, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string Document { get; set; }

        [Display(Name = "Prénom")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string FirstName { get; set; }

        [Display(Name = "Nom")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string LastName { get; set; }

        [Display(Name = "Adresse")]
        [MaxLength(100, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        public string Address { get; set; }

        [Display(Name = "Nom complet")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Nom complet")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
