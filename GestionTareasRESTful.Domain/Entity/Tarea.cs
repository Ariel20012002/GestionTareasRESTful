using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Domain.Entity
{
    public class Tarea
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
