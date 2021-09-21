﻿// <auto-generated />
using System;
using HospitalEnCasa.app.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalEnCasa.app.Persistencia.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Anotacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("enfermeraId")
                        .HasColumnType("int");

                    b.Property<string>("formula_medica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("medicoId")
                        .HasColumnType("int");

                    b.Property<int?>("pacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("enfermeraId");

                    b.HasIndex("medicoId");

                    b.HasIndex("pacienteId");

                    b.ToTable("anotaciones");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Historia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("anotacionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("anotacionId");

                    b.ToTable("historias");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedula")
                        .HasColumnType("int");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("cedula")
                        .IsUnique();

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Enfermera", b =>
                {
                    b.HasBaseType("HospitalEnCasa.app.Dominio.Persona");

                    b.Property<string>("hospital")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Enfermera_hospital");

                    b.Property<string>("informacion_laboral")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Enfermera");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Familiar_Designado", b =>
                {
                    b.HasBaseType("HospitalEnCasa.app.Dominio.Persona");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Familiar_Designado_direccion");

                    b.Property<int>("latitud")
                        .HasColumnType("int")
                        .HasColumnName("Familiar_Designado_latitud");

                    b.Property<int>("longitud")
                        .HasColumnType("int")
                        .HasColumnName("Familiar_Designado_longitud");

                    b.HasDiscriminator().HasValue("Familiar_Designado");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Medico", b =>
                {
                    b.HasBaseType("HospitalEnCasa.app.Dominio.Persona");

                    b.Property<string>("hospital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tarjeta_profesional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tiempo_experiencia")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Paciente", b =>
                {
                    b.HasBaseType("HospitalEnCasa.app.Dominio.Persona");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("enfermeraId")
                        .HasColumnType("int");

                    b.Property<int?>("familiarId")
                        .HasColumnType("int");

                    b.Property<int>("latitud")
                        .HasColumnType("int");

                    b.Property<int>("longitud")
                        .HasColumnType("int");

                    b.Property<int?>("medicoId")
                        .HasColumnType("int");

                    b.HasIndex("enfermeraId");

                    b.HasIndex("familiarId");

                    b.HasIndex("medicoId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Anotacion", b =>
                {
                    b.HasOne("HospitalEnCasa.app.Dominio.Enfermera", "enfermera")
                        .WithMany()
                        .HasForeignKey("enfermeraId");

                    b.HasOne("HospitalEnCasa.app.Dominio.Medico", "medico")
                        .WithMany()
                        .HasForeignKey("medicoId");

                    b.HasOne("HospitalEnCasa.app.Dominio.Paciente", "paciente")
                        .WithMany()
                        .HasForeignKey("pacienteId");

                    b.Navigation("enfermera");

                    b.Navigation("medico");

                    b.Navigation("paciente");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Historia", b =>
                {
                    b.HasOne("HospitalEnCasa.app.Dominio.Anotacion", "anotacion")
                        .WithMany()
                        .HasForeignKey("anotacionId");

                    b.Navigation("anotacion");
                });

            modelBuilder.Entity("HospitalEnCasa.app.Dominio.Paciente", b =>
                {
                    b.HasOne("HospitalEnCasa.app.Dominio.Enfermera", "enfermera")
                        .WithMany()
                        .HasForeignKey("enfermeraId");

                    b.HasOne("HospitalEnCasa.app.Dominio.Familiar_Designado", "familiar")
                        .WithMany()
                        .HasForeignKey("familiarId");

                    b.HasOne("HospitalEnCasa.app.Dominio.Medico", "medico")
                        .WithMany()
                        .HasForeignKey("medicoId");

                    b.Navigation("enfermera");

                    b.Navigation("familiar");

                    b.Navigation("medico");
                });
#pragma warning restore 612, 618
        }
    }
}
