using FluentValidation;

namespace RapNacionalAPI.Validations
{
    public class ExemploValidation : AbstractValidator<Object>
    {
        public ExemploValidation() 
        {
            //RuleFor(x => x.Email)
            //    .NotEmpty()
            //       .WithMessage("O email não pode ser vazio")
            //    .GreaterThan(1);
        }
    }
}
