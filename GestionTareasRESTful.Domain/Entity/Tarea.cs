﻿using System.ComponentModel.DataAnnotations;

namespace GestionTareasRESTful.Domain.Entity
{
    public class Tarea
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string? Comentario { get; set; }
        public int EstTarea { get; set; }
        public int Estado { get; set; }
    }
}
