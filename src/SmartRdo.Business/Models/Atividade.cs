using System;
using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class Atividade : Entity
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public DateTime InicioPrevisto { get; set; }

        public DateTime FimPrevisto { get; set; }

        public string LocalDescarte { get; set; }

        public Guid ClienteId { get; set; }

        public Guid AreaId { get; set; }

        public ICollection<AtividadeOperador> AtividadeOperador { get; set; }

        public ICollection<AtividadeRecurso> AtividadeRecurso { get; set; }

        public IEnumerable<AtividadeFotos> AtividadeFotos { get; set; }

        /* EF */
        public Cliente Cliente { get; set; }

        public Area Area { get; set; }
    }
}
