using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Models.Validations
{
    public class TeamValidation : AbstractValidator<Team>
    {
        public TeamValidation()
        {
            RuleFor(n => n.Name)
               .NotEmpty().WithMessage("O campo Nome é obrigátorio")
               .Length(2, 50)
               .WithMessage("O campo Nome deve ter entre {MinLength} e {MaxLenght} caracteres");

            RuleFor(e => e.Job)
              .NotEmpty().WithMessage("O campo Função é obrigátorio")
              .Length(2, 50)
              .WithMessage("O campo Função deve ter entre {MinLength} e {MaxLenght} caracteres");

            RuleFor(e => e.UrlGitHub)
            .NotEmpty().WithMessage("O campo GitHub é obrigátorio")
            .Length(2, 50)
            .WithMessage("O campo GitHub deve ter entre {MinLength} e {MaxLenght} caracteres");
        }
    }
}
