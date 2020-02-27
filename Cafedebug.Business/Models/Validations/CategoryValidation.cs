using FluentValidation;

namespace Cafedebug.Business.Validations
{
    public class CategoryValidation : AbstractValidator<Models.Category>
    {
        public CategoryValidation()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("O campo Nome é obrigátorio")
                .Length(5, 100).WithMessage("O campo Nome deve ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
