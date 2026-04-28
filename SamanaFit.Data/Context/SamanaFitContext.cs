using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SamanaFit.Data.Models;

namespace SamanaFit.Data.Context;

public partial class SamanaFitContext : DbContext
{
    public SamanaFitContext()
    {
    }

    public SamanaFitContext(DbContextOptions<SamanaFitContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DetalleRutina> DetalleRutinas { get; set; }

    public virtual DbSet<Ejercicio> Ejercicios { get; set; }

    public virtual DbSet<Nivel> Nivels { get; set; }

    public virtual DbSet<Objetivo> Objetivos { get; set; }

    public virtual DbSet<Rutina> Rutinas { get; set; }

    public virtual DbSet<Sexo> Sexos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SamanaFitPro;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DetalleRutina>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__DetalleR__E43646A5D08B34BF");

            entity.HasOne(d => d.IdEjercicioNavigation).WithMany(p => p.DetalleRutinas).HasConstraintName("FK_DetalleRutina_Ejercicios");

            entity.HasOne(d => d.IdRutinaNavigation).WithMany(p => p.DetalleRutinas).HasConstraintName("FK_DetalleRutina_Rutinas");
        });

        modelBuilder.Entity<Ejercicio>(entity =>
        {
            entity.HasKey(e => e.IdEjercicio).HasName("PK__Ejercici__F0E6D605D6316D58");

            entity.Property(e => e.Descripcion).HasMaxLength(255);

            entity.HasOne(d => d.IdNivelNavigation).WithMany(p => p.Ejercicios).HasConstraintName("FK_Ejercicios_Nivel");
        });

        modelBuilder.Entity<Nivel>(entity =>
        {
            entity.HasKey(e => e.IdNivel).HasName("PK__Nivel__A7F93DEC91AE3020");
        });

        modelBuilder.Entity<Objetivo>(entity =>
        {
            entity.HasKey(e => e.IdObjetivo).HasName("PK__Objetivo__E210F07150B145C8");
        });

        modelBuilder.Entity<Rutina>(entity =>
        {
            entity.HasKey(e => e.IdRutina).HasName("PK__Rutinas__6E34CA3D3687D11B");

            entity.Property(e => e.Observaciones).HasMaxLength(255);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Rutinas).HasConstraintName("FK_Rutinas_Usuarios");

            entity.HasOne(d => d.IdNivelNavigation).WithMany(p => p.Rutinas).HasConstraintName("FK_Rutinas_Nivel");

            entity.HasOne(d => d.IdObjetivoNavigation).WithMany(p => p.Rutinas).HasConstraintName("FK_Rutinas_Objetivos");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__5B65BF977DDDC54F");

            entity.HasOne(d => d.IdNivelNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK_Usuarios_Nivel");

            entity.HasOne(d => d.IdObjetivoNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK_Usuarios_Objetivos");

            entity.HasOne(d => d.IdSexoNavigation).WithMany(p => p.Usuarios).HasConstraintName("FK_Usuarios_Sexo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
