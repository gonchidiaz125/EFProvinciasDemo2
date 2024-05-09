﻿// <auto-generated />
using System;
using EFProvinciasDemo2.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFProvinciasDemo2.Migrations
{
    [DbContext(typeof(MiDbContext))]
    partial class MiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioAltaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioBajaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioModificacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.HasIndex("UsuarioAltaId");

                    b.HasIndex("UsuarioBajaId");

                    b.HasIndex("UsuarioModificacionId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioAltaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioBajaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioModificacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("UsuarioAltaId");

                    b.HasIndex("UsuarioBajaId");

                    b.HasIndex("UsuarioModificacionId");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdLocalidad")
                        .HasColumnType("int");

                    b.Property<int>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioAltaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioBajaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioModificacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.HasIndex("UsuarioAltaId");

                    b.HasIndex("UsuarioBajaId");

                    b.HasIndex("UsuarioModificacionId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioAltaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioBajaId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioModificacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioAltaId");

                    b.HasIndex("UsuarioBajaId");

                    b.HasIndex("UsuarioModificacionId");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Departamento", b =>
                {
                    b.HasOne("EFProvinciasDemo2.Entities.Provincia", "Provincia")
                        .WithMany("Departamentos")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioAlta")
                        .WithMany()
                        .HasForeignKey("UsuarioAltaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioBaja")
                        .WithMany()
                        .HasForeignKey("UsuarioBajaId");

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioModificacion")
                        .WithMany()
                        .HasForeignKey("UsuarioModificacionId");

                    b.Navigation("Provincia");

                    b.Navigation("UsuarioAlta");

                    b.Navigation("UsuarioBaja");

                    b.Navigation("UsuarioModificacion");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Localidad", b =>
                {
                    b.HasOne("EFProvinciasDemo2.Entities.Departamento", "Departamento")
                        .WithMany("Localidades")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioAlta")
                        .WithMany()
                        .HasForeignKey("UsuarioAltaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioBaja")
                        .WithMany()
                        .HasForeignKey("UsuarioBajaId");

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioModificacion")
                        .WithMany()
                        .HasForeignKey("UsuarioModificacionId");

                    b.Navigation("Departamento");

                    b.Navigation("UsuarioAlta");

                    b.Navigation("UsuarioBaja");

                    b.Navigation("UsuarioModificacion");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Persona", b =>
                {
                    b.HasOne("EFProvinciasDemo2.Entities.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioAlta")
                        .WithMany()
                        .HasForeignKey("UsuarioAltaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioBaja")
                        .WithMany()
                        .HasForeignKey("UsuarioBajaId");

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioModificacion")
                        .WithMany()
                        .HasForeignKey("UsuarioModificacionId");

                    b.Navigation("Localidad");

                    b.Navigation("UsuarioAlta");

                    b.Navigation("UsuarioBaja");

                    b.Navigation("UsuarioModificacion");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Provincia", b =>
                {
                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioAlta")
                        .WithMany()
                        .HasForeignKey("UsuarioAltaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioBaja")
                        .WithMany()
                        .HasForeignKey("UsuarioBajaId");

                    b.HasOne("EFProvinciasDemo2.Entities.Usuario", "UsuarioModificacion")
                        .WithMany()
                        .HasForeignKey("UsuarioModificacionId");

                    b.Navigation("UsuarioAlta");

                    b.Navigation("UsuarioBaja");

                    b.Navigation("UsuarioModificacion");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Departamento", b =>
                {
                    b.Navigation("Localidades");
                });

            modelBuilder.Entity("EFProvinciasDemo2.Entities.Provincia", b =>
                {
                    b.Navigation("Departamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
