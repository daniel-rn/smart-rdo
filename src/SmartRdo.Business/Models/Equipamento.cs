using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartRdo.Business.Models
{
    public class Equipamento : Entity
    {
        public Equipamento()
        {
            ItensChecklist = new List<ItemChecklistEquipamento>();
        }

        [Display(Name = "Nome do Equipamento")]
        public string Nome { get; set; }

        /* EF Relations */
        public List<ItemChecklistEquipamento> ItensChecklist { get; set; }
    }
}
