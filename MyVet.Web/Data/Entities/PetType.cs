using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Type d'animaux")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
