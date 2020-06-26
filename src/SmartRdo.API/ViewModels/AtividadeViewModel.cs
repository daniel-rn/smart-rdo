using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRdo.API.ViewModels
{
    public class AtividadeViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(5, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [DisplayName("Inicio da atividade")]
        public DateTime Inicio { get; set; }

        [DisplayName("Fim da atividade")]
        public DateTime Fim { get; set; }

        [DisplayName("Estimativa de tempo para a atividade")]
        public int Estimativa { get; set; }

        [DisplayName("Local de descarte dos resíduos")]
        public string LocalDescarte { get; set; }
    }
}
