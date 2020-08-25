using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartRdo.Business.Models
{
    public class Atividade : Entity
    {
        /*
         * Criar model no front e remover data anotations daqui
         */

        [Display(Name = "Código")]
        public string Codigo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        [Display(Name = "Inicio")]
        public DateTime InicioPrevisto { get; set; }
        [Display(Name = "Fim")]
        public DateTime FimPrevisto { get; set; }
        [Display(Name = "Cliente")]
        public Guid ClienteId { get; set; }
        public Guid AreaId { get; set; }
        public Guid ResponsavelAreaId { get; set; }
        public Guid OperadorId { get; set; }
        public AvaliacaoAtividade AvaliacaoAtividade { get; set; }
        public ICollection<AtividadeOperador> AtividadeOperador { get; set; }
        public ICollection<AtividadeRecurso> AtividadeRecurso { get; set; }
        public IEnumerable<AtividadeFotos> AtividadeFotos { get; set; }

        /* EF */
        [Display(Name = "Cliente")]
        public Cliente Cliente { get; set; }
        [Display(Name = "Área")]
        public Area Area { get; set; }
        [Display(Name = "Responsável")]
        public ResponsavelArea ResponsavelArea { get; set; }

        [Display(Name = "Operador")]
        public Operador Operador { get; set; }


        public string StatusAtividade => "Iniciada";
    }
}
