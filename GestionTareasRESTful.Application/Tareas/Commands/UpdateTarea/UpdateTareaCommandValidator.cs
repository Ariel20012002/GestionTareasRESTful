using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Commands.UpdateTarea
{
    public class UpdateTareaCommandValidator : AbstractValidator<UpdateTareaCommand>
    {
        public UpdateTareaCommandValidator() 
        {
            RuleFor(v => v.Nombre)
                .NotEmpty().WithMessage("Escriba una tarea para continuar")
                .MaximumLength(50).WithMessage("No debe escribir mas de 50 caracteres");

            RuleFor(v => v.Comentario)
                .MaximumLength(255).WithMessage("No debe escribir mas de 255 caracteres");
        }
    }
}
