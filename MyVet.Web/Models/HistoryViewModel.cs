using Microsoft.AspNetCore.Mvc.Rendering;
using MyVet.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class HistoryViewModel : History
    {
        public int PetId { get; set; }

        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        [Display(Name = "Type de service")]
        [Range(1, int.MaxValue, ErrorMessage = "Veuillez sélectionner le type de service")]
        public int ServiceTypeId { get; set; }

        public IEnumerable<SelectListItem> ServiceTypes { get; set; }
    }
}
