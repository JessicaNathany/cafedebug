using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Areas.Administrador.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        [StringLength(50, ErrorMessage ="O campo precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string Name { get; set; }
    }
}
