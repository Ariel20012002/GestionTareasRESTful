﻿using GestionTareasRESTful.Application.Tareas.Commands.UpdateTarea;
using GestionTareasRESTful.Domain.Entity;
using GestionTareasRESTful.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Commands.DeleteTarea
{
    public class DeleteTareaCommandHandler : IRequestHandler<DeleteTareaCommand, int>
    {
        private readonly ITareaRepository _tareaRepository;
        
        public DeleteTareaCommandHandler(ITareaRepository tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }

        public async Task<int> Handle(DeleteTareaCommand request, CancellationToken cancellationToken)
        {
            var deleteTareaEntity = new Tarea()
            {
                Id = request.Id,
                Estado = request.Estado
            };
            return await _tareaRepository.UpdateStateAsync(request.Id, deleteTareaEntity);
        }
    }
}
