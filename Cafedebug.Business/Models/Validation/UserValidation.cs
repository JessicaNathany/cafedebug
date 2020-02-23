using FluentValidation;

namespace Cafedebug.Business.Models.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("O campo {PropertyName}, precisa ser preenchido");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("O campo {PropertyName}, precisa ser preenchido");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("O campo {PropertyName}, precisa ser preenchido")
                .Length(2, 8).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(u=> u.Login)
                .NotEmpty().WithMessage("O campo {PropertyName}, precisa ser preenchido")
                .Length(2, 8).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
