namespace SmartRdo.Business.Models
{
    public class Cliente : Entity   
    {
        public string Nome { get; set; }

        /* EF Relations */
        public Atividade Atividade { get; set; }

    }
}
