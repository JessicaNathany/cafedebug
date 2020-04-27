using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Areas.Site.ViewModels
{
    public class ContactViewModel
    {
        public ContactViewModel()
        {
            Code = Guid.NewGuid();
        }
        public int Id { get; set; }
        public Guid Code { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Email precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Mensagem é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string Message { get; set; }
    }
}