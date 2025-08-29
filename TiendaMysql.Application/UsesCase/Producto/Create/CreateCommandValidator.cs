using FluentValidation;

namespace TiendaMysql.Application.UsesCase.Producto.Create
{
    public class CreateCommandValidator: AbstractValidator<CreateCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("El nombre es obligatorio")
                .MaximumLength(100).WithMessage("El nombre no puede tener más de 100 caracteres");
            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("El precio debe ser mayor que cero");
        }
    }
}
