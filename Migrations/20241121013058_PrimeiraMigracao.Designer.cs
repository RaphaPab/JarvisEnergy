﻿// <auto-generated />
using System;
using JarvisEnergy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace JarvisEnergy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241121013058_PrimeiraMigracao")]
    partial class PrimeiraMigracao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JarvisEnergy.Models.Dispositivo", b =>
                {
                    b.Property<int>("IdDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_DISPOSITIVO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDispositivo"));

                    b.Property<string>("ConsumoWatts")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DescricaoDispositivo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("DS_DISPOSITIVO");

                    b.Property<string>("NomeDispositivo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("NVARCHAR2(150)")
                        .HasColumnName("NM_DISPOSITIVO");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("DS_STATUS");

                    b.Property<string>("Temperatura")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Voltagem")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("NR_VOLTAGEM");

                    b.HasKey("IdDispositivo");

                    b.ToTable("TJD_JS_DISPOSITIVO");
                });

            modelBuilder.Entity("JarvisEnergy.Models.EnderecoUsuario", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_ENDERECO_CLIENTE");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)")
                        .HasColumnName("NM_BAIRRO");

                    b.Property<string>("Residencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("NR_RESIDENCIA");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("NM_RUA");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USUARIO");

                    b.HasKey("IdEndereco");

                    b.ToTable("TJD_JS_ENDERECO_USUARIO");
                });

            modelBuilder.Entity("JarvisEnergy.Models.Relatorio", b =>
                {
                    b.Property<int>("IdRelatorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_RELATORIO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRelatorio"));

                    b.Property<string>("DescricaoRelatorio")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)")
                        .HasColumnName("DS_RELATORIO");

                    b.Property<string>("NomeRelatorio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("NM_RELATORIO");

                    b.Property<long>("NumeroRelatorio")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("NR_RELATORIO");

                    b.Property<string>("TipoRelatorio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)")
                        .HasColumnName("TP_RELATORIO");

                    b.HasKey("IdRelatorio");

                    b.ToTable("TJD_JS_RELATORIO");
                });

            modelBuilder.Entity("JarvisEnergy.Models.Telefone", b =>
                {
                    b.Property<int>("IdTelefone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_TELEFONE");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTelefone"));

                    b.Property<int>("Ddd")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("NR_DDD");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("DS_TELEFONE");

                    b.Property<long>("NumeroTelefone")
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("NR_TELEFONE");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USUARIO");

                    b.HasKey("IdTelefone");

                    b.ToTable("TJD_JS_TELEFONE");
                });

            modelBuilder.Entity("JarvisEnergy.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USUARIO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NR_CPF");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_NASCIMENTO");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)")
                        .HasColumnName("NM_USUARIO");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NR_RG");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("NVARCHAR2(150)")
                        .HasColumnName("CD_SENHA");

                    b.HasKey("IdUsuario");

                    b.ToTable("TJD_JS_USUARIO");
                });

            modelBuilder.Entity("JarvisEnergy.Models.UsuarioDispositivo", b =>
                {
                    b.Property<int>("IdUsuarioDispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USUARIO_DISPOSITIVO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuarioDispositivo"));

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_FIM");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_INICIO");

                    b.Property<int>("DispositivoId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_DISPOSITIVO");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("ID_USUARIO");

                    b.HasKey("IdUsuarioDispositivo");

                    b.ToTable("TJD_JS_USUARIO_DISPOSITIVO");
                });
#pragma warning restore 612, 618
        }
    }
}