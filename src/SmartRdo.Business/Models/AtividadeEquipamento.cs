using System;

namespace SmartRdo.Business.Models
{
    public class AtividadeEquipamento : Entity
    {
        public Guid AtividadeId { get; set; }
        public Guid EquipamentoId { get; set; }

        /* EF */
        public Atividade Atividade { get; set; }
        public Equipamento Equipamento { get; set; }
    }
}
