using System.Collections.Generic;

namespace SmartRdo.Business.Models
{
    public class ResponsavelArea : Entity
    {
        public string Nome { get; set; }

        public ICollection<ResponsaveisArea> Areas { get; set; }
    }
}
