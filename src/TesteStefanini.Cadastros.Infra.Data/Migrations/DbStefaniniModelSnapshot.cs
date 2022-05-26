﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

#nullable disable

namespace TesteStefanini.Cadastros.Infra.Data.Migrations
{
    [DbContext(typeof(DbStefanini))]
    partial class DbStefaniniModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TesteStefanini.Cadastros.Dominios.Entidades.Cidades.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasColumnName("nome");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("cidades", (string)null);
                });

            modelBuilder.Entity("TesteStefanini.Cadastros.Dominios.Entidades.Pessoas.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int")
                        .HasColumnName("cidade_id");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(120)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("pessoas", (string)null);
                });

            modelBuilder.Entity("TesteStefanini.Cadastros.Dominios.Entidades.Pessoas.Pessoa", b =>
                {
                    b.HasOne("TesteStefanini.Cadastros.Dominios.Entidades.Cidades.Cidade", "Cidade")
                        .WithMany("Pessoas")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("TesteStefanini.Cadastros.Dominios.Entidades.Cidades.Cidade", b =>
                {
                    b.Navigation("Pessoas");
                });
#pragma warning restore 612, 618
        }
    }
}
