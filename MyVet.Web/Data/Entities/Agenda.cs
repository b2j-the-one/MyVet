﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm tt}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Display(Name = "Remarques")]
        public string Remarks { get; set; }

        [Display(Name = "Est disponible ?")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm tt}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

        public Owner Owner { get; set; }

        public Pet Pet { get; set; }
    }
}