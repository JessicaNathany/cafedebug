using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.Areas.Administrador.ViewModels
{
    public class TeamViewModel
    {
        public TeamViewModel()
        {
            Code = Guid.NewGuid();
        }

        public Guid Code { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome precisa ter entre {2} e {1} caracteres.", MinimumLength = 5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Url GitHub é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Url GitHub precisa ter entre {2} e {1} caracteres.", MinimumLength = 5)]
        public string UrlGitHub { get; set; }

        public string UrlInstagram { get; set; }

        public string UrlLinkedin { get; set; }

        [Required(ErrorMessage = "O campo Url Image é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Url Image precisa ter entre {2} e {1} caracteres.", MinimumLength = 5)]
        public string UrlImage { get; set; }

        [Required(ErrorMessage = "O campo Função é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Função precisa ter entre {2} e {1} caracteres.", MinimumLength = 5)]
        public string Job { get; set; }

        [Required(ErrorMessage = "O campo Upload é obrigátorio")]
        public IFormFile ImagemUpload { get; set; }
    }
}
