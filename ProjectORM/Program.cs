using ProjectORM.Entities;
using System;
using System.Linq;

namespace ProjectORM
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                //var profesor = new Profesor 
                //{
                //    Materia = "Informatica",
                //    Nombre = "Roberto",
                //};

                //context.Add(profesor);
                //context.SaveChanges();

                var profesor = context.Set<Profesor>()
                    .Where(q => q.ProfesorId == 1)
                    .FirstOrDefault();


                Console.WriteLine($"Nombre = {profesor.Nombre}");

                var curso = new Curso();
                curso.Profesor = profesor;
                curso.Dia = "martes";

                var alumno1 = new Alumno();
                var alumno2 = new Alumno();

                alumno1.Curso = curso;
                alumno1.Apellido="Perez";

                alumno2.Curso = curso;
                alumno2.Apellido = "Gonzalez";

                context.Add(alumno1);
                context.Add(alumno2);
                context.SaveChanges();








            }
        }
    }
}
