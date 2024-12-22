using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Commands.RemoveTarea
{
    public class RemoveTareaCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
