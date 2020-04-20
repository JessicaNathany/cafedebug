using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafedebug.Business.Models.Validations
{
    public class ContactValidation : AbstractValidator<Contact>
    {
        public ContactValidation()
        {
            RuleFor(n => n.Name)
               .NotEmpty().WithMessage("O campo Nome é obrigátorio")
               .Length(2, 50)
               .WithMessage("O campo Nome deve ter entre {MinLength} e {MaxLenght} caracteres");

            RuleFor(e => e.Email)
              .NotEmpty().WithMessage("O campo Email é obrigátorio")
              .EmailAddress().WithMessage("O campo email é obrigatório");

            RuleFor(e => e.Message)
              .NotEmpty().WithMessage("O campo Message é obrigátorio")
              .Length(2, 50)
              .WithMessage("O campo Nome deve ter entre {MinLength} e {MaxLenght} caracteres");
        }
    }
}
