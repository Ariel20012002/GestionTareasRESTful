using GestionTareasRESTful.Application.Common.Mappings;
using GestionTareasRESTful.Domain.Entity;
using System.ComponentModel.DataAnnotations;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareas
{
    public class TareaVm : IMapFrom<Tarea>
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string? Comentario { get; set; }
        public int Est_Tarea { get; set; }
        public int Estado { get; set; }
    }
}
