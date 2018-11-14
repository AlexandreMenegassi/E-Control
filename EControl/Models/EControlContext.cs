using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EControl.Models
{
    public partial class EControlContext : DbContext
    {
        public EControlContext()
        {
        }

        public EControlContext(DbContextOptions<EControlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Preco> Preco { get; set; }
        public virtual DbSet<Servico> Servico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EControl;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.Property(e => e.Cargo).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Nascimento).HasColumnType("date");

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Sexo).IsUnicode(false);

                entity.Property(e => e.Sobrenome).IsUnicode(false);

                entity.Property(e => e.TelefoneCel).IsUnicode(false);

                entity.Property(e => e.TelefoneRes).IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Complemento).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Endereco).IsUnicode(false);

                entity.Property(e => e.EnderecoNum).IsUnicode(false);

                entity.Property(e => e.Nascimento).HasColumnType("date");

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Profissao).IsUnicode(false);

                entity.Property(e => e.Sexo).IsUnicode(false);

                entity.Property(e => e.Sobrenome).IsUnicode(false);

                entity.Property(e => e.TelefoneCel).IsUnicode(false);

                entity.Property(e => e.TelefoneRes).IsUnicode(false);
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .IsUnicode(false);

                entity.Property(e => e.DescricaoEmp).IsUnicode(false);

                entity.Property(e => e.Endereco).IsUnicode(false);

                entity.Property(e => e.NomeEmp).IsUnicode(false);

                entity.Property(e => e.NomeRep).IsUnicode(false);

                entity.Property(e => e.TelefoneCel1).IsUnicode(false);

                entity.Property(e => e.TelefoneCel2).IsUnicode(false);

                entity.Property(e => e.TelefoneCom1).IsUnicode(false);

                entity.Property(e => e.TelefoneCom2).IsUnicode(false);
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.Property(e => e.Cargo).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Endereco).IsUnicode(false);

                entity.Property(e => e.EnderecoNum).IsUnicode(false);

                entity.Property(e => e.Nascimento).IsUnicode(false);

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.Sexo).IsUnicode(false);

                entity.Property(e => e.Sobrenome).IsUnicode(false);

                entity.Property(e => e.TelefoneCel).IsUnicode(false);

                entity.Property(e => e.TelefoneRes).IsUnicode(false);
            });

            modelBuilder.Entity<Preco>(entity =>
            {
                entity.Property(e => e.Custo).HasColumnType("money");

                entity.Property(e => e.ServicoNom).IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Preco)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK_Preco_ToTable");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.Property(e => e.Custo).HasColumnType("money");

                entity.Property(e => e.Nome).IsUnicode(false);

                entity.Property(e => e.TipoPag).IsUnicode(false);

                entity.Property(e => e.Valor).HasColumnType("money");
            });
        }
    }
}
