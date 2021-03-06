// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Valera.Lucia.Cerasus.API.DataBase;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20220428202416_InitinalCreate")]
    partial class InitinalCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Presupuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.PresupuestoLinea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PresupuestoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PresupuestoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("PresupuestoLinea");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Comidas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Evento")
                        .HasColumnType("TEXT");

                    b.Property<int>("Invitados")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Lugar")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Telefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.PresupuestoLinea", b =>
                {
                    b.HasOne("Valera.Lucia.Cerasus.API.Models.Presupuesto", "Presupuesto")
                        .WithMany("Lineas")
                        .HasForeignKey("PresupuestoId");

                    b.HasOne("Valera.Lucia.Cerasus.API.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");

                    b.Navigation("Presupuesto");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Producto", b =>
                {
                    b.HasOne("Valera.Lucia.Cerasus.API.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Valera.Lucia.Cerasus.API.Models.Presupuesto", b =>
                {
                    b.Navigation("Lineas");
                });
#pragma warning restore 612, 618
        }
    }
}
