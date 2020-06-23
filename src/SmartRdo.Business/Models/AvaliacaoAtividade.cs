using System;

namespace SmartRdo.Business.Models
{
    //Enum AvaliacaoAtividade
    //{
        
    //}

    public class AvaliacaoAtividade : Entity
    {
        public Guid AtividadeId { get; set; }

        public string Observacao { get; set; }
    }
}