using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartRdo.MVC.Models
{
    public class AreaViewModel
    {
        [Required]
        [Display(Name = "Código")]
        public Guid CodigoArea { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Responsáveis")]
        public IEnumerable<ResponsaveisAreaViewModel> ResponsaveisDaArea { get; set; }
    }
}
