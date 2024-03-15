using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ejericio1.Models;

public partial class Ejercicio1Context : DbContext
{
    public Ejercicio1Context()
    {
    }

    public Ejercicio1Context(DbContextOptions<Ejercicio1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__ROLES__2A49584C3C36C5B8");

            entity.ToTable("ROLES");

            entity.HasIndex(e => e.NombreRol, "UQ__ROLES__4F0B537F71CCB169").IsUnique();

            entity.Property(e => e.NombreRol)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07F2694957");

            entity.HasIndex(e => e.CorreoElectronico, "UQ__Usuarios__531402F3EF4EE796").IsUnique();

            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.RolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Rol)
                .HasConstraintName("FK__Usuarios__Rol__286302EC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
