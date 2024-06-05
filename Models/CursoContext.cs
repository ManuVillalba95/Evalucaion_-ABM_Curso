using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Evalucaion__ABM_Curso.Models
{
    public partial class CursoContext : DbContext
    {
        public CursoContext()
        {
        }

        public CursoContext(DbContextOptions<CursoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=MANUEL\\MVILLALBA; Database=Curso; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasIndex(e => e.Cuil, "UQ__Cursos__AFA9178EAD375EF0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil).HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
