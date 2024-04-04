using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proyectoAnimales.Models;

public partial class ProyectoAnimalesContext : DbContext
{
    public ProyectoAnimalesContext()
    {
    }

    public ProyectoAnimalesContext(DbContextOptions<ProyectoAnimalesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animale> Animales { get; set; }

    public virtual DbSet<Propietario> Propietarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animale>(entity =>
        {
            entity.HasKey(e => e.AnimalId).HasName("PK__Animales__A21A73276AD2B870");

            entity.Property(e => e.AnimalId).HasColumnName("AnimalID");
            entity.Property(e => e.Especie).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.PropietarioId).HasColumnName("PropietarioID");

            entity.HasOne(d => d.Propietario).WithMany(p => p.Animales)
                .HasForeignKey(d => d.PropietarioId)
                .HasConstraintName("FK__Animales__Propie__398D8EEE");
        });

        modelBuilder.Entity<Propietario>(entity =>
        {
            entity.HasKey(e => e.PropietarioId).HasName("PK__Propieta__BDE3FD6530A41FCA");

            entity.Property(e => e.PropietarioId).HasColumnName("PropietarioID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
