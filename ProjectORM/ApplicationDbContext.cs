using Microsoft.EntityFrameworkCore;
using ProjectORM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectORM
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=cursogyl;Trusted_Connection=True;Integrated Security=True;;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Profesor> Profesores{ get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
