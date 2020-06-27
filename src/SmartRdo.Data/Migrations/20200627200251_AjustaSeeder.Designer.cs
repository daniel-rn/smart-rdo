﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SmartRdo.Data.Context;

namespace SmartRdo.Data.Migrations
{
    [DbContext(typeof(SmartRdoDbContext))]
    [Migration("20200627200251_AjustaSeeder")]
    partial class AjustaSeeder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SmartRdo.Business.Models.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CodigoArea")
                        .IsRequired()
                        .HasColumnType("varchar(13)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"),
                            CodigoArea = "0001",
                            Nome = "Galpao"
                        },
                        new
                        {
                            Id = new Guid("a92df7e5-8692-4859-80ec-9662e5524989"),
                            CodigoArea = "0002",
                            Nome = "Patio"
                        },
                        new
                        {
                            Id = new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"),
                            CodigoArea = "0003",
                            Nome = "Refeitorioa"
                        },
                        new
                        {
                            Id = new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"),
                            CodigoArea = "0004",
                            Nome = "Producao"
                        },
                        new
                        {
                            Id = new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"),
                            CodigoArea = "0005",
                            Nome = "Almoxarifado"
                        });
                });

            modelBuilder.Entity("SmartRdo.Business.Models.Atividade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AreaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("FimPrevisto")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("InicioPrevisto")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LocalDescarte")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("ResponsavelAreaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ResponsavelAreaId");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AtividadeFotos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AtividadeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AtividadeId");

                    b.ToTable("AtividadesFotos");
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AtividadeOperador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AtividadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OperadorId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AtividadeId");

                    b.HasIndex("OperadorId");

                    b.ToTable("AtividadesOperadores");
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AtividadeRecurso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AtividadeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RecursoId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AtividadeId");

                    b.HasIndex("RecursoId");

                    b.ToTable("AtividadesRecursos");
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AvaliacaoAtividade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AtividadeId")
                        .HasColumnType("uuid");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("AtividadeId")
                        .IsUnique();

                    b.ToTable("AvaliacaoAtividade");
                });

            modelBuilder.Entity("SmartRdo.Business.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47019220-7be5-45db-b1c8-c7246d4c3bce"),
                            Nome = "Cliente A"
                        },
                        new
                        {
                            Id = new Guid("865a1cfb-6972-48a6-9f64-fa18f59261cf"),
                            Nome = "Cliente B"
                        });
                });

            modelBuilder.Entity("SmartRdo.Business.Models.Operador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Operadores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"),
                            Nome = "Daniel Nascimento"
                        },
                        new
                        {
                            Id = new Guid("a92df7e5-8692-4859-80ec-9662e5524989"),
                            Nome = "Murilo Seno"
                        },
                        new
                        {
                            Id = new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"),
                            Nome = "Gabriel Cotrim"
                        },
                        new
                        {
                            Id = new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"),
                            Nome = "Gustavo Sousa"
                        },
                        new
                        {
                            Id = new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"),
                            Nome = "Ronaldo Ghesti"
                        });
                });

            modelBuilder.Entity("SmartRdo.Business.Models.Recurso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Recursos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("60f9b002-0f51-481c-a657-98a99e132242"),
                            Nome = "Recurso A"
                        },
                        new
                        {
                            Id = new Guid("1bd1c1ec-c7c4-4042-a321-8a5fe4647b43"),
                            Nome = "Recurso B"
                        });
                });

            modelBuilder.Entity("SmartRdo.Business.Models.ResponsaveisArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AreaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ResponsavelAreaId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ResponsavelAreaId");

                    b.ToTable("ResponsaveisArea");
                });

            modelBuilder.Entity("SmartRdo.Business.Models.ResponsavelArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Responsaveis");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"),
                            Nome = "Daniel Nascimento"
                        },
                        new
                        {
                            Id = new Guid("a92df7e5-8692-4859-80ec-9662e5524989"),
                            Nome = "Murilo Seno"
                        },
                        new
                        {
                            Id = new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"),
                            Nome = "Gabriel Cotrim"
                        },
                        new
                        {
                            Id = new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"),
                            Nome = "Gustavo Sousa"
                        },
                        new
                        {
                            Id = new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"),
                            Nome = "Ronaldo Ghesti"
                        });
                });

            modelBuilder.Entity("SmartRdo.Business.Models.Atividade", b =>
                {
                    b.HasOne("SmartRdo.Business.Models.Area", "Area")
                        .WithMany("Atividades")
                        .HasForeignKey("AreaId")
                        .IsRequired();

                    b.HasOne("SmartRdo.Business.Models.Cliente", "Cliente")
                        .WithMany("Atividades")
                        .HasForeignKey("ClienteId")
                        .IsRequired();

                    b.HasOne("SmartRdo.Business.Models.ResponsavelArea", "ResponsavelArea")
                        .WithMany()
                        .HasForeignKey("ResponsavelAreaId")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AtividadeFotos", b =>
                {
                    b.HasOne("SmartRdo.Business.Models.Atividade", "Atividade")
                        .WithMany("AtividadeFotos")
                        .HasForeignKey("AtividadeId")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AtividadeOperador", b =>
                {
                    b.HasOne("SmartRdo.Business.Models.Atividade", "Ativividade")
                        .WithMany("AtividadeOperador")
                        .HasForeignKey("AtividadeId")
                        .IsRequired();

                    b.HasOne("SmartRdo.Business.Models.Operador", "Operador")
                        .WithMany("AtividadeOperador")
                        .HasForeignKey("OperadorId")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AtividadeRecurso", b =>
                {
                    b.HasOne("SmartRdo.Business.Models.Atividade", "Atividade")
                        .WithMany("AtividadeRecurso")
                        .HasForeignKey("AtividadeId")
                        .IsRequired();

                    b.HasOne("SmartRdo.Business.Models.Recurso", "Recurso")
                        .WithMany("AtividadeRecurso")
                        .HasForeignKey("RecursoId")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartRdo.Business.Models.AvaliacaoAtividade", b =>
                {
                    b.HasOne("SmartRdo.Business.Models.Atividade", null)
                        .WithOne("AvaliacaoAtividade")
                        .HasForeignKey("SmartRdo.Business.Models.AvaliacaoAtividade", "AtividadeId")
                        .IsRequired();
                });

            modelBuilder.Entity("SmartRdo.Business.Models.ResponsaveisArea", b =>
                {
                    b.HasOne("SmartRdo.Business.Models.Area", "Area")
                        .WithMany("ResponsaveisDaArea")
                        .HasForeignKey("ResponsavelAreaId")
                        .IsRequired();

                    b.HasOne("SmartRdo.Business.Models.ResponsavelArea", "Responsavel")
                        .WithMany("Areas")
                        .HasForeignKey("ResponsavelAreaId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
