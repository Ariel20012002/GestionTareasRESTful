﻿using AutoMapper;
using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using GestionTareasRESTful.Domain.Entity;
using GestionTareasRESTful.Domain.Repository;
using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Commands.CreateTarea
{
    public class CreateTareaCommandHandler : IRequestHandler<CreateTareaCommand, TareaVm>
    {
        private readonly ITareaRepository _tareaRepository;
        private readonly IMapper _mapper;   
        public CreateTareaCommandHandler(ITareaRepository tareaRepository, IMapper mapper) 
        {
            _tareaRepository = tareaRepository;
            _mapper = mapper;
        }
        public async Task<TareaVm> Handle(CreateTareaCommand request, CancellationToken cancellationToken)
        {
            var tareaEnity = new Tarea() 
            { 
                Nombre = request.Nombre,
                Comentario = request.Comentario,
                EstTarea = request.EstTarea,
                Estado = request.Estado
            };
            var Result = await _tareaRepository.CreateAsync(tareaEnity);
            return _mapper.Map<TareaVm>(Result);
        }
    }
}
