﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafedebug.Web.ViewModels
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
        [StringLength(50, ErrorMessage = "O campo Nome precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Url GitHub é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string UrlGitHub { get; set; }

        public string UrlInstagram { get; set; }

        public string UrlLinkedin { get; set; }

        [Required(ErrorMessage = "O campo Url Image é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string UrlImage { get; set; }

        [Required(ErrorMessage = "O campo Função é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome precisa ter entre {0} e {1} caracteres.", MinimumLength = 5)]
        public string Job { get; set; }
    }
}
