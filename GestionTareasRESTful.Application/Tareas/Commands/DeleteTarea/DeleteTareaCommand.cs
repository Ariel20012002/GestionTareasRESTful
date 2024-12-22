using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Commands.DeleteTarea
{
    public class DeleteTareaCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int Estado { get; set; }
    }
}
