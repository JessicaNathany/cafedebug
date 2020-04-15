using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Models
{
    public class ContactViewModel
    {
        public ContactViewModel()
        {

        }


        public IEnumerable<SelectListItem> Assuntos
        {
            get
            {
                return new List<SelectListItem>()
                {
                    new SelectListItem() { Value = "1", Text = "Sugestões" },
                    new SelectListItem() { Value = "2", Text = "Elogios" },
                    new SelectListItem() { Value = "3", Text = "Críticas" },
                    new SelectListItem() { Value = "4", Text = "Parceria" },
                    new SelectListItem() { Value = "5", Text = "Eventos" },
                    new SelectListItem() { Value = "6", Text = "Outros" },

                };
            }

        }


    }
}



