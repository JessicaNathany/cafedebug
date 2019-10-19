using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Cafedebug.Web.ActionFilters
{
    /// <summary>
    /// Classe ActionFilter para autenticação do usuário
    /// </summary>
    public class AuthenticationFilter : Attribute, IActionFilter, IOrderedFilter
    {
        public int Order => throw new NotImplementedException();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
