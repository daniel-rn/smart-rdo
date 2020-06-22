namespace SmartRdo.Business.Models
{
    public class Operador : Entity
    {
        public string Nome { get; set; }

        /* EF Relations */
        public Atividade Atividade { get; set; }
    }
}