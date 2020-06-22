using System;

namespace SmartRdo.Business.Models
{
    public class AtividadeFotos : Entity
    {
        public string Foto { get; set; }
        public Guid AtividadeId { get; set; }

        /* EF Relations */
        public Atividade Atividade { get; set; }
    }
}