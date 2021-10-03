﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Colegio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.ToTable("Arbitro");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Desempeño", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GolesAfavor")
                        .HasColumnType("int");

                    b.Property<int>("GolesEncontra")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPartidos")
                        .HasColumnType("int");

                    b.Property<int>("PartidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("PartidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Desempeño");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectorTecnico");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DirectorTecnico_idId")
                        .HasColumnType("int");

                    b.Property<int?>("Municipio_idId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorTecnico_idId");

                    b.HasIndex("Municipio_idId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MunicipioId");

                    b.HasIndex("PartidoId");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.MarcadorFinal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EquipoGanador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipoPerdedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MarcadorGanador")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorPerdedor")
                        .HasColumnType("int");

                    b.Property<int?>("PartidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartidoId");

                    b.ToTable("MarcadorFinal");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Novedades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("JugadorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Minuto")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreNovedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RedCards")
                        .HasColumnType("int");

                    b.Property<int>("YellowCards")
                        .HasColumnType("int");

                    b.Property<int>("goles")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JugadorId");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Equipo_Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipo_Visitante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Marcador_Inicial_Equipo_Local")
                        .HasColumnType("int");

                    b.Property<int>("Marcador_Inicial_Equipo_Visitante")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Partido");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Partido", "Partido")
                        .WithMany()
                        .HasForeignKey("PartidoId");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.DirectorTecnico", "DirectorTecnico_id")
                        .WithMany()
                        .HasForeignKey("DirectorTecnico_idId");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "Municipio_id")
                        .WithMany()
                        .HasForeignKey("Municipio_idId");

                    b.Navigation("DirectorTecnico_id");

                    b.Navigation("Municipio_id");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Partido", "Partido")
                        .WithMany()
                        .HasForeignKey("PartidoId");

                    b.Navigation("Municipio");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", null)
                        .WithMany("Jugadores")
                        .HasForeignKey("EquipoId");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.MarcadorFinal", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Partido", "Partido")
                        .WithMany()
                        .HasForeignKey("PartidoId");

                    b.Navigation("Partido");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Novedades", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Jugador", "Jugador")
                        .WithMany()
                        .HasForeignKey("JugadorId");

                    b.Navigation("Jugador");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.Navigation("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
