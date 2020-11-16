using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SA.Models
{
    public partial class churrascariaContext : DbContext
    {
        public churrascariaContext()
        {
        }

        public churrascariaContext(DbContextOptions<churrascariaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cadastro> Cadastro { get; set; }
        public virtual DbSet<Mesas> Mesas { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;database=churrascaria;user=root;treattinyasboolean=true", x => x.ServerVersion("10.4.14-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cadastro>(entity =>
            {
                entity.ToTable("cadastro");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Areatrabalho)
                    .HasColumnName("AREATRABALHO")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Bairro)
                    .HasColumnName("BAIRRO")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cidade)
                    .HasColumnName("CIDADE")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("CNPJ")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Complemento)
                    .HasColumnName("COMPLEMENTO")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Cpf)
                    .HasColumnName("CPF")
                    .HasColumnType("varchar(11)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Numero)
                    .HasColumnName("NUMERO")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Rua)
                    .HasColumnName("RUA")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Senha)
                    .HasColumnName("SENHA")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Telefone)
                    .HasColumnName("TELEFONE")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Mesas>(entity =>
            {
                entity.ToTable("mesas");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Nomemesa)
                    .HasColumnName("NOMEMESA")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Observacao)
                    .HasColumnName("OBSERVACAO")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.ToTable("pedidos");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Observacao)
                    .HasColumnName("OBSERVACAO")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("decimal(10,2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
