using GestionTareasRESTful.Domain.Entity;
using GestionTareasRESTful.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Est_Tarea = request.Est_Tarea,
            };

            return await _tareaRepository.UpdateAsync(request.Id, updateTareaEntity);
        }
    }
}
