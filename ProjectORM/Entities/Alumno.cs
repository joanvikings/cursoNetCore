using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectORM.Entities
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        public int Edad{ get; set; }
        public string Apellido { get; set; }
        public Curso Curso { get; set; }
    }
}
