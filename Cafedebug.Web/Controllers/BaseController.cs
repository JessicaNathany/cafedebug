using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafedebug.Business.Interfaces;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace Cafedebug.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(BaseController));
        private readonly INotifier _notifier;

        public BaseController(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected bool ValidOperation()
        {
            return !_notifier.HasNotification();
        }
    }
}