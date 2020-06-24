using System;

namespace SmartRdo.Business.Models
{
    public class ResponsaveisArea
    {
        public Guid AreaId { get; set; }
        public Guid ResponsavelAreaId { get; set; }

        /* EF */
        public Area Area { get; set; }
        public ResponsavelArea Responsavel { get; set; }
    } 
}
