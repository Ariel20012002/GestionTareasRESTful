using AutoMapper;
using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using GestionTareasRESTful.Domain.Entity;
using GestionTareasRESTful.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Est_Tarea = request.Est_Tarea,
                Estado = request.Estado,    
                Create_Time = request.Create_Time,
                Update_Time = request.Update_Time
            };
            var Result = await _tareaRepository.CreateAsync(tareaEnity);
            return _mapper.Map<TareaVm>(Result);
        }
    }
}
