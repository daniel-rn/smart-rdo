using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartRdo.MVC.Models
{
    public class AtividadeViewModel
    {
        [Key]
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(5, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Codigo { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Display(Name = "Previsão de início")]
        [Required]
        public DateTime InicioPrevisto { get; set; }

        [Display(Name = "Previsão de término")]
        [Required]
        public DateTime FimPrevisto { get; set; }

        public Guid OperadorId { get; set; }

        [Display(Name = "Local de descarte dos resíduos")]
        public string LocalDescarte { get; set; }

        [Display(Name = "Cliente")]
        public ClienteViewModel Cliente { get; set; }

        [Display(Name = "Área")]
        public AreaViewModel Area { get; set; }

        [Display(Name = "Responsável da área")]
        public ResponsavelArea ResponsavelArea { get; set; }

        [Display(Name = "Operador")]
        public Operador Operador { get; set; }

    }
}
