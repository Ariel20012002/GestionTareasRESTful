using GestionTareasRESTful.Domain.Entity;
using GestionTareasRESTful.Domain.Repository;
using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Commands.UpdateTarea
{
    
    public class UpdateTareaCommandHandler : IRequestHandler<UpdateTareaCommand, int>
    {
        private readonly ITareaRepository _tareaRepository;
        public UpdateTareaCommandHandler(ITareaRepository tareaRepository) { 
            _tareaRepository = tareaRepository;
        }

        public async Task<int> Handle(UpdateTareaCommand request, CancellationToken cancellationToken)
        {
            var updateTareaEntity = new Tarea()
            {
                Id = request.Id,
                Nombre = request.Nombre,
                Comentario = request.Comentario,
                EstTarea = request.EstTarea,
            };

            return await _tareaRepository.UpdateAsync(request.Id, updateTareaEntity);
        }
    }
}
