using Cafedebug.Business.Notificacoes;
using System.Collections.Generic;

namespace Cafedebug.Business.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
