using System;
using System.Collections.Generic;

namespace Evalucaion__ABM_Curso.Models
{
    public partial class Curso
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string Cuil { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string? Nivel { get; set; }
    }
}
