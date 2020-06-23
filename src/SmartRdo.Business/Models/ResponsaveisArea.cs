using System;

namespace SmartRdo.Business.Models
{
    public class ResponsaveisArea
    {
        public Guid AreaId { get; set; }
        public Guid ResponsavelAreaId { get; set; }

        /* EF */
        public Area Atividade { get; set; }
        public ResponsavelArea Recurso { get; set; }
    } 
}
