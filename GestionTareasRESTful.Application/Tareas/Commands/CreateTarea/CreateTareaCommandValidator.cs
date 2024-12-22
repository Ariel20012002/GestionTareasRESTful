using FluentValidation;

namespace GestionTareasRESTful.Application.Tareas.Commands.CreateTarea
{
    public class CreateTareaCommandValidator : AbstractValidator<CreateTareaCommand>
    {
        public CreateTareaCommandValidator() 
        {
            RuleFor(v => v.Nombre)
                .NotEmpty().WithMessage("Escriba una tarea para continuar")
                .MaximumLength(50).WithMessage("No debe escribir mas de 50 caracteres");

            RuleFor(v => v.Comentario)
                .MaximumLength(255).WithMessage("No debe escribir mas de 255 caracteres");

            RuleFor(v => v.Est_Tarea)
                .NotEmpty().WithMessage("Debe seleccionar un estado");

            RuleFor(v => v.Estado)
                .NotEmpty().WithMessage("Debe insertar un estado para realizar operaciones");
        }
    }
}
