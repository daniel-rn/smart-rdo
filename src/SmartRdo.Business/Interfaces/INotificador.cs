using SmartRdo.Business.Notificacoes;
using System.Collections.Generic;

namespace SmartRdo.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
