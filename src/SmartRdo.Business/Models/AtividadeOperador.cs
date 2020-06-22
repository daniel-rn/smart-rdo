using SmartRdo.Business.Models;
using System;

namespace SmartRdo.Business.Models
{
    public class AtividadeOperador : Entity
    {
        public Guid AtividadeId { get; set; }
        public Guid OperadorId { get; set; }

        /* EF */
        public Atividade Ativividade { get; set; }
        public Operador Operador { get; set; }
    }
}
