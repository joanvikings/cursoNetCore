using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectORM.Entities
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }

        public ICollection<Curso> Cursos { get; set; }
    }
}
