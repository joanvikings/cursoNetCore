using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectORM.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Dia { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public ICollection<Alumno> Alumnos { get; set; }
    }
}
