using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Creditos.Models;

public partial class CreditosContext : DbContext
{
    public CreditosContext()
    {
    }

    public CreditosContext(DbContextOptions<CreditosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=Creditos; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3213E83F86D0CED7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApellidoM).HasMaxLength(50);
            entity.Property(e => e.ApellidoP).HasMaxLength(50);
            entity.Property(e => e.Cantidad).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Telefono).HasMaxLength(32);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
