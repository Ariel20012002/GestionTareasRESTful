using GestionTareasRESTful.Application.Common.Mappings;
using GestionTareasRESTful.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareas
{
    public class TareaVm : IMapFrom<Tarea>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Comentario { get; set; }
        public int Est_Tarea { get; set; }
        public int Estado { get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Update_Time { get; set; }
    }
}
