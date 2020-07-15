using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartRdo.MVC.Models
{
    public class ResponsavelAreaViewModel
    {
        [Required]
        [Display(Name = "Código")]
        public Guid Codigo { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Responsáveis Area")]
        public ICollection<ResponsaveisAreaViewModel> Areas { get; set; }
    }
}
