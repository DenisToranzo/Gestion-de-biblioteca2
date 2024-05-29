using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Restaurante.Models;

public partial class DbpruebaContext : DbContext
{
    public DbpruebaContext()
    {
    }

    public DbpruebaContext(DbContextOptions<DbpruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-G8L5S41\\SQLEXPRESS; database=DBPRUEBA; integrated security=true; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Libros__3214EC07CF4048EA");

            entity.Property(e => e.Autor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreLibro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_libro");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__5B65BF97F677FBD1");

            entity.ToTable("USUARIO");

            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
