using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class Cliente : Entity   
    {
        public string Nome { get; set; }

        /* EF Relations */
        public IEnumerable<Atividade> Atividades { get; set; }

    }
}
