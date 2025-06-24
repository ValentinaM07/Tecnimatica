using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Api_Tecnimatica.DAO;

public partial class PruebaContext : DbContext
{
    public PruebaContext()
    {
    }

    public PruebaContext(DbContextOptions<PruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-5T52LBVT\\MSSQLSERVER8;Initial Catalog=Prueba;TrustServerCertificate=True;Integrated Security=SSPI");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.IdPel).HasName("pk_cp");

            entity.ToTable("pelicula");

            entity.Property(e => e.IdPel)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_pel");
            entity.Property(e => e.AnhoPel).HasColumnName("Anho_pel");
            entity.Property(e => e.GeneroPel)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("Genero_pel");
            entity.Property(e => e.TituloPel)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Titulo_pel");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUs).HasName("pk_cu");

            entity.ToTable("usuario");

            entity.Property(e => e.IdUs)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_us");
            entity.Property(e => e.ContrasenaUs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Contraseña_us");
            entity.Property(e => e.EmailUs)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Email_us");

            entity.HasMany(d => d.IdPel1s).WithMany(p => p.IdUs1s)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioPelicula",
                    r => r.HasOne<Pelicula>().WithMany()
                        .HasForeignKey("IdPel1")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_Ec2"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdUs1")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_Ec1"),
                    j =>
                    {
                        j.HasKey("IdUs1", "IdPel1").HasName("pk_cup");
                        j.ToTable("usuario_pelicula");
                        j.IndexerProperty<int>("IdUs1").HasColumnName("Id_us1");
                        j.IndexerProperty<int>("IdPel1").HasColumnName("Id_pel1");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
