using FluentValidation;

namespace Cafedebug.Business.Models.Validations
{
    public class EpisodeValidation : AbstractValidator<Episode>
    {
        public EpisodeValidation()
        {
            RuleFor(t => t.Title)
                .NotEmpty().WithMessage("O campo Título e obrigátorio")
                .Length(2, 50)
                .WithMessage("O campo Título deve ter entre {MinLength} e {MaxLenght} caracteres");

            RuleFor(d => d.Title)
                .NotEmpty().WithMessage("O campo Descrição e obrigátorio")
                .Length(10, 500)
                .WithMessage("O campo Título deve ter entre {MinLength} e {MaxLenght} caracteres");

            RuleFor(i => i.ImageUrl)
                .NotEmpty().WithMessage("O campo Imagem e obrigátorio");

            RuleFor(u => u.Url)
                .NotEmpty().WithMessage("O campo Url Episodio e obrigátorio");
        }
    }
}
