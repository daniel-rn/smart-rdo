using System;

namespace SmartRdo.Business.Models
{
    public class ItemChecklistEquipamento : Entity
    {
        public string Descricao { get; set; }
        public Guid IdEquipamento { get; set; }

        /* EF Relations */
        public Equipamento Equipamento { get; set; }
    }
}
