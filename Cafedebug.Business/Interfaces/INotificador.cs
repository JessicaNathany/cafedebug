using Cafedebug.Business.Notificacoes;
using System.Collections.Generic;

namespace Cafedebug.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
