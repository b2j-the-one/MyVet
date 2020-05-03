using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        
        ////[Display(Name = "Document")]
        ////[MaxLength(30, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        ////[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        ////public string Document { get; set; }

        ////[Display(Name = "Prénom")]
        ////[MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        ////[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        ////public string FirstName { get; set; }

        ////[Display(Name = "Nom")]
        ////[MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        ////[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        ////public string LastName { get; set; }

        ////[MaxLength(20)]
        ////[Display(Name = "Téléphone fixe")]
        ////public string FixedPhone { get; set; }

        ////[Display(Name = "Téléphone portable")]
        ////[MaxLength(20, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        ////[Required(ErrorMessage = "The field {0} is mandatory.")]
        ////public string CellPhone { get; set; }

        ////[Display(Name = "Adresse")]
        ////[MaxLength(100, ErrorMessage = "Le champ {0} ne peut pas avoir plus de {1} caractères.")]
        ////[Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        ////public string Address { get; set; }

        ////public string FullName
        ////{
        ////    get
        ////    {
        ////        return $"{this.FirstName} {this.LastName}";
        ////    }
        ////}

        ////[Display(Name = "Propriétaire")]
        ////public string FullName => $"{this.FirstName} {this.LastName}";

        ////[Display(Name = "Propriétaire")]
        ////public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public User User { get; set; }
        
        public ICollection<Pet> Pets { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}
