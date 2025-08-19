using FluentValidation;

namespace Winforms
{
    public class Validator : AbstractValidator<People>
    {
        public Validator()
        {
            RuleFor(x=> x.Name)
                .NotEmpty().WithMessage("Nome não pode ser vazio!")
                .MinimumLength(3).WithMessage("O nome não pode ter menos de 3 caracteres")
                .MaximumLength(255).WithMessage("O nome não pode ter mais de 255 caracteres");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Não cadastrou um Email válido");

            RuleFor(x => x.Age)
                .GreaterThan(0).WithMessage("Idade não pode ser menor ou igual a zero!");
        }
    }
}
