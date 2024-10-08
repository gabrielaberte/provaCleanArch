﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProvaCleanArch.Data;

#nullable disable

namespace ProvaCleanArch.Data.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240826141620_matriculaMigrations")]
    partial class matriculaMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfessorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vagas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Curso", (string)null);
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Matricula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("CursoId");

                    b.ToTable("Matricula", (string)null);
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Professor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professor", (string)null);
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Curso", b =>
                {
                    b.HasOne("ProvaCleanArch.Domain.Model.Professor", "Professor")
                        .WithMany("Cursos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Matricula", b =>
                {
                    b.HasOne("ProvaCleanArch.Domain.Model.Aluno", "Aluno")
                        .WithMany("Matriculas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProvaCleanArch.Domain.Model.Curso", "Curso")
                        .WithMany("Matriculas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Aluno", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Curso", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("ProvaCleanArch.Domain.Model.Professor", b =>
                {
                    b.Navigation("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
