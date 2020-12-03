﻿using System;
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
        public virtual DbSet<Estoque> Estoque { get; set; }
        public virtual DbSet<Itensdto> Itensdto { get; set; }
        public virtual DbSet<Itenspedido> Itenspedido { get; set; }
        public virtual DbSet<Mesas> Mesas { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }

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

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.ToTable("estoque");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Identificacao)
                    .HasColumnName("IDENTIFICACAO")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.QuantidadeKg)
                    .HasColumnName("QUANTIDADE_KG")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorKg)
                    .HasColumnName("VALOR_KG")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("VALOR_TOTAL")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Itensdto>(entity =>
            {
                entity.HasKey(e => e.Quantidade)
                    .HasName("PRIMARY");

                entity.ToTable("itensdto");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("quantidade")
                    .HasColumnType("int(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Itenspedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PRIMARY");

                entity.ToTable("itenspedido");

                entity.Property(e => e.IdPedido)
                    .HasColumnType("int(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdProduto).HasColumnType("int(2)");

                entity.Property(e => e.Quantidade).HasColumnType("int(2)");

                entity.Property(e => e.Total).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorProduto).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Mesas>(entity =>
            {
                entity.ToTable("mesas");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nomemesa)
                    .HasColumnName("NOMEMESA")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Observacao)
                    .HasColumnName("OBSERVACAO")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statusmesa)
                    .HasColumnName("STATUSMESA")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statuspedido)
                    .HasColumnName("STATUSPEDIDO")
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

                entity.Property(e => e.Datapedido)
                    .HasColumnName("DATAPEDIDO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Produtos>(entity =>
            {
                entity.ToTable("produtos");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasColumnType("varchar(50)")
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
