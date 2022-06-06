﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valera.Lucia.Cerasus.API.DataBase;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20220514150729_Create16")]
    partial class Create16
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Boda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Bodas");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Comida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Precio")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Comidas");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Comunion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comuniones");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Contacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Corporativo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Corporativos");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lema")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Perfil")
                        .HasColumnType("TEXT");

                    b.Property<string>("Puesto")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Filosofia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Filosofias");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Lugar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Precio")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Lugares");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ComidaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Invitados")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LugarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NombreEvento")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComidaId");

                    b.HasIndex("LugarId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Suscriptor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Correo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Suscriptores");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Producto", b =>
                {
                    b.HasOne("Valera.Lucia.Cerasus.API.Models.Comida", "Comida")
                        .WithMany()
                        .HasForeignKey("ComidaId");

                    b.HasOne("Valera.Lucia.Cerasus.API.Models.Lugar", "Lugar")
                        .WithMany()
                        .HasForeignKey("LugarId");

                    b.HasOne("Valera.Lucia.Cerasus.API.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Comida");

                    b.Navigation("Lugar");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
