using FluentValidation;

namespace SmartRdo.Business.Models.Validacoes
{
    public class AtividadeValidation : AbstractValidator<Atividade>
    {
        public AtividadeValidation()
        {
            RuleFor(a => a.Codigo)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 3)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
