using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class ContaFixaValidation : AbstractValidator<ContaFixa>
    {
        public ContaFixaValidation()
        {
            RuleFor(c => c.NomeConta)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.Valor)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}