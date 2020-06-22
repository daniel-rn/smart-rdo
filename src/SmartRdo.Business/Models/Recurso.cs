using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class Recurso : Entity
    {

        /* EF Relations */
        public ICollection<AtividadeRecurso> AtividadeRecurso { get; set; }
    }
}