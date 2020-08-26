using System.ComponentModel;

namespace SmartRdo.Business.Models
{
    public enum AtividadeStatus
    {
        [Description("Não Iniciada")]
        NaoIniciada,
        [Description("Iniciada")]
        Iniciada,
        [Description("Concluída")]
        Concluida,
        [Description("Aguardando Revisão")]
        AguardandoRevisao
    }
}
