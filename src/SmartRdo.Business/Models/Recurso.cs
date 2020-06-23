using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class Recurso : Entity
    {
        public string Nome { get; set; }
        /* EF Relations */
        public ICollection<AtividadeRecurso> AtividadeRecurso { get; set; }
    }
}