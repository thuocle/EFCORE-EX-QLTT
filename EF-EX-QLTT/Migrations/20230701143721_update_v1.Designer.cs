﻿// <auto-generated />
using System;
using EF_EX_QLTT.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_EX_QLTT.Migrations
{
    [DbContext(typeof(AppDbConText))]
    [Migration("20230701143721_update_v1")]
    partial class update_v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_EX_QLTT.Entities.HocVien", b =>
                {
                    b.Property<int>("HocVienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HocVienID"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LopID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayDK")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrinhDo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HocVienID");

                    b.HasIndex("LopID");

                    b.ToTable("HocVien");
                });

            modelBuilder.Entity("EF_EX_QLTT.Entities.Lop", b =>
                {
                    b.Property<int>("LopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopID"));

                    b.Property<int>("TenLop")
                        .HasColumnType("int");

                    b.HasKey("LopID");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("EF_EX_QLTT.Entities.HocVien", b =>
                {
                    b.HasOne("EF_EX_QLTT.Entities.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });
#pragma warning restore 612, 618
        }
    }
}
