using System.ComponentModel.DataAnnotations;

namespace SmartRdo.MVC.Models
{
    public class ResponsaveisAreaViewModel
    {
        [Required]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Área")]
        public AreaViewModel Area { get; set; }
        
        [Required]
        [Display(Name = "Responsável Área")]
        public ResponsavelAreaViewModel Responsavel { get; set; }
    }
}
