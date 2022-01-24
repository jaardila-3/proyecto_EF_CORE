﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using PruebaBDPrimero.Entidades;

#nullable disable

namespace PruebaBDPrimero.Migrations
{
    [DbContext(typeof(EFCorePeliculasDBContext))]
    [Migration("20220115141549_prueba")]
    partial class prueba
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosIdentificador")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.HasKey("GenerosIdentificador", "PeliculasId");

                    b.HasIndex(new[] { "PeliculasId" }, "IX_GeneroPelicula_PeliculasId");

                    b.ToTable("GeneroPelicula", (string)null);
                });

            modelBuilder.Entity("PeliculaSalaDeCine", b =>
                {
                    b.Property<int>("PeliculasId")
                        .HasColumnType("int");

                    b.Property<int>("SalasDeCineId")
                        .HasColumnType("int");

                    b.HasKey("PeliculasId", "SalasDeCineId");

                    b.HasIndex(new[] { "SalasDeCineId" }, "IX_PeliculaSalaDeCine_SalasDeCineId");

                    b.ToTable("PeliculaSalaDeCine", (string)null);
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Actore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BillingAddressCalle")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BillingAddress_Calle");

                    b.Property<string>("BillingAddressPais")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BillingAddress_Pais");

                    b.Property<string>("BillingAddressProvincia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BillingAddress_Provincia");

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("FotoURL");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actores");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoDeEtica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Historia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Misiones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Geometry>("Ubicacion")
                        .HasColumnType("geography");

                    b.Property<string>("Valores")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cines");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.CinesOferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<decimal>("PorcentajeDescuento")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CineId" }, "IX_CinesOfertas_CineId")
                        .IsUnique()
                        .HasFilter("([CineId] IS NOT NULL)");

                    b.ToTable("CinesOfertas");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Genero", b =>
                {
                    b.Property<int>("Identificador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identificador"), 1L, 1);

                    b.Property<string>("Ejemplo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("EstaBorrado")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("(CONVERT([bit],(0)))");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Identificador");

                    b.HasIndex(new[] { "Nombre" }, "IX_Generos_Nombre")
                        .IsUnique()
                        .HasFilter("([EstaBorrado]='false')");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ejemplo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Mensaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmisorId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EmisorId" }, "IX_Mensajes_EmisorId");

                    b.HasIndex(new[] { "ReceptorId" }, "IX_Mensajes_ReceptorId");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Merchandising", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("DisponibleEnInventario")
                        .HasColumnType("bit");

                    b.Property<bool>("EsColeccionable")
                        .HasColumnType("bit");

                    b.Property<bool>("EsRopa")
                        .HasColumnType("bit");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<double>("Volumen")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Merchandising", (string)null);
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CorreoElectronico")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("date");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoPago")
                        .HasColumnType("int");

                    b.Property<string>("Ultimos4Digitos")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("PosterUrl")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("PosterURL");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.PeliculasActore", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("PeliculaId", "ActorId");

                    b.HasIndex(new[] { "ActorId" }, "IX_PeliculasActores_ActorId");

                    b.ToTable("PeliculasActores");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.PeliculasAlquilable", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PeliculasAlquilables");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.PeliculasConConteo", b =>
                {
                    b.Property<int?>("CantidadActores")
                        .HasColumnType("int");

                    b.Property<int?>("CantidadCines")
                        .HasColumnType("int");

                    b.Property<int?>("CantidadGeneros")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.ToView("PeliculasConConteos");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.SalasDeCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ElCine")
                        .HasColumnType("int");

                    b.Property<string>("Moneda")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(9,2)");

                    b.Property<string>("TipoSalaDeCine")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'DosDimensiones')");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ElCine" }, "IX_SalasDeCine_ElCine");

                    b.ToTable("SalasDeCine", (string)null);
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosIdentificador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaBDPrimero.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeliculaSalaDeCine", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaBDPrimero.Entidades.SalasDeCine", null)
                        .WithMany()
                        .HasForeignKey("SalasDeCineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.CinesOferta", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Cine", "Cine")
                        .WithOne("CinesOferta")
                        .HasForeignKey("PruebaBDPrimero.Entidades.CinesOferta", "CineId");

                    b.Navigation("Cine");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Mensaje", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Persona", "Emisor")
                        .WithMany("MensajeEmisors")
                        .HasForeignKey("EmisorId")
                        .IsRequired();

                    b.HasOne("PruebaBDPrimero.Entidades.Persona", "Receptor")
                        .WithMany("MensajeReceptors")
                        .HasForeignKey("ReceptorId")
                        .IsRequired();

                    b.Navigation("Emisor");

                    b.Navigation("Receptor");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Merchandising", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Producto", "IdNavigation")
                        .WithOne("Merchandising")
                        .HasForeignKey("PruebaBDPrimero.Entidades.Merchandising", "Id")
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.PeliculasActore", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Actore", "Actor")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaBDPrimero.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.PeliculasAlquilable", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Producto", "IdNavigation")
                        .WithOne("PeliculasAlquilable")
                        .HasForeignKey("PruebaBDPrimero.Entidades.PeliculasAlquilable", "Id")
                        .IsRequired();

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.SalasDeCine", b =>
                {
                    b.HasOne("PruebaBDPrimero.Entidades.Cine", "ElCineNavigation")
                        .WithMany("SalasDeCines")
                        .HasForeignKey("ElCine")
                        .IsRequired();

                    b.Navigation("ElCineNavigation");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Actore", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Cine", b =>
                {
                    b.Navigation("CinesOferta");

                    b.Navigation("SalasDeCines");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Pelicula", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Persona", b =>
                {
                    b.Navigation("MensajeEmisors");

                    b.Navigation("MensajeReceptors");
                });

            modelBuilder.Entity("PruebaBDPrimero.Entidades.Producto", b =>
                {
                    b.Navigation("Merchandising");

                    b.Navigation("PeliculasAlquilable");
                });
#pragma warning restore 612, 618
        }
    }
}
