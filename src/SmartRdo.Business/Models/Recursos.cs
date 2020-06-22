namespace SmartRdo.Business.Models
{
    public class Recursos : Entity
    {

        /* EF Relations */
        public Atividade Atividade {  get; set;  }
    }
}