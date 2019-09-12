using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class OpflixContext : DbContext
    {
        public OpflixContext()
        {
        }

        public OpflixContext(DbContextOptions<OpflixContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Conteudo> Conteudo { get; set; }
        public virtual DbSet<Fs> Fs { get; set; }
        public virtual DbSet<Plataforma> Plataforma { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SqlExpress;Initial Catalog=T_Opflix;User Id=sa;Pwd=132");
            }
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Conteudo>(entity =>
            {
                entity.HasKey(e => e.IdConteudo);

                entity.Property(e => e.Dlanc)
                    .HasColumnName("DLanc")
                    .HasColumnType("date");

                entity.Property(e => e.IdFs).HasColumnName("IdFS");

                entity.Property(e => e.Sinopse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Conteudo)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Conteudo__IdCate__70DDC3D8");

                entity.HasOne(d => d.IdFsNavigation)
                    .WithMany(p => p.Conteudo)
                    .HasForeignKey(d => d.IdFs)
                    .HasConstraintName("FK__Conteudo__IdFS__71D1E811");

                entity.HasOne(d => d.IdPlataformaNavigation)
                    .WithMany(p => p.Conteudo)
                    .HasForeignKey(d => d.IdPlataforma)
                    .HasConstraintName("FK__Conteudo__IdPlat__72C60C4A");
            });

            modelBuilder.Entity<Fs>(entity =>
            {
                entity.HasKey(e => e.IdFs);

                entity.ToTable("FS");

                entity.Property(e => e.IdFs).HasColumnName("IdFS");

                entity.Property(e => e.Qual)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Plataforma>(entity =>
            {
                entity.HasKey(e => e.IdPlataforma);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.Cpf).HasColumnName("CPF");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Permissao)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });
        }
    }
}
