using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nom")]
        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [MaxLength(50, ErrorMessage = "Le champ {0} ne peut pas comporter plus de {1} caractères.")]
        public string Race { get; set; }

        [Display(Name = "Né le")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire.")]
        //[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }

        [Display(Name = "Remarques")]
        public string Remarks { get; set; }


        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://TDB.azurewebsites.net{ImageUrl.Substring(1)}";

        [Display(Name = "Né le")]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BornLocal => Born.ToLocalTime();

        public Owner Owner { get; set; }

        public PetType PetType { get; set; }

        public ICollection<History> Histories { get; set; }

        public ICollection<Agenda> Agendas { get; set; }
    }
}