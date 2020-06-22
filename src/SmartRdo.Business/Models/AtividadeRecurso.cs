using SmartRdo.Business.Models;
using System;

namespace SmartRdo.Business.Models
{
    public class AtividadeRecurso : Entity
    {
        public Guid AtividadeId { get; set; }
        public Guid RecursoId { get; set; }

        /* EF */
        public Atividade Atividade { get; set; }
        public Recurso Recurso { get; set; }
    }
}
