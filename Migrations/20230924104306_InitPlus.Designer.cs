﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLTTTM.models;

#nullable disable

namespace DAPM.Migrations
{
    [DbContext(typeof(DataSQLContext))]
    [Migration("20230924104306_InitPlus")]
    partial class InitPlus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLTTTM.models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MANV")
                        .HasColumnType("int");

                    b.Property<string>("MATKHAU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TAIKHOAN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("QLTTTM.models.ChucNang", b =>
                {
                    b.Property<int>("MACN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MACN"));

                    b.Property<string>("TENCN")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("MACN");

                    b.ToTable("ChucNangs");
                });

            modelBuilder.Entity("QLTTTM.models.ChucVu", b =>
                {
                    b.Property<int>("MACV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MACV"));

                    b.Property<string>("TENCV")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("MACV");

                    b.ToTable("ChucVus");
                });

            modelBuilder.Entity("QLTTTM.models.DoiTac", b =>
                {
                    b.Property<int>("MADT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MADT"));

                    b.Property<string>("DIRECTION")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IMAGEPATH")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MALOAIDOITAC")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TENDT")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("MADT");

                    b.ToTable("DoiTacs");
                });

            modelBuilder.Entity("QLTTTM.models.HopDong", b =>
                {
                    b.Property<int>("MAHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MAHD"));

                    b.Property<DateTime>("HIEULUC")
                        .HasColumnType("datetime2");

                    b.Property<string>("LOAIHOPDONG")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("MANV")
                        .HasColumnType("int");

                    b.Property<string>("NOIDUNG")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TENHDDT")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("THOIHAN")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MAHD");

                    b.ToTable("HopDongs");
                });

            modelBuilder.Entity("QLTTTM.models.HopDongDoiTac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MADT")
                        .HasColumnType("int");

                    b.Property<int>("MAHD")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HopDongDoiTacs");
                });

            modelBuilder.Entity("QLTTTM.models.HopDongMatBang", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MAHD")
                        .HasColumnType("int");

                    b.Property<int>("MAKH")
                        .HasColumnType("int");

                    b.Property<int>("MAMB")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HopDongMatBangs");
                });

            modelBuilder.Entity("QLTTTM.models.KhachHang", b =>
                {
                    b.Property<int>("MAKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MAKH"));

                    b.Property<string>("DIACHI")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("GIOITINH")
                        .HasColumnType("bit");

                    b.Property<string>("HOTEN")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MAMB")
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAYSINH")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("TRANGTHAI")
                        .HasColumnType("bit");

                    b.HasKey("MAKH");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("QLTTTM.models.LoaiDoiTac", b =>
                {
                    b.Property<int>("MALOAIDT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MALOAIDT"));

                    b.Property<string>("TENLOAI")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("MALOAIDT");

                    b.ToTable("LoaiDoiTacs");
                });

            modelBuilder.Entity("QLTTTM.models.MatBang", b =>
                {
                    b.Property<int>("MAMB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MAMB"));

                    b.Property<float>("DIENTICH")
                        .HasColumnType("real");

                    b.Property<int>("GIATIEN")
                        .HasColumnType("int");

                    b.Property<string>("IMAGEPATH")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("IMAGEPATH1")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("IMAGEPATH2")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MOTA")
                        .IsRequired()
                        .HasMaxLength(300000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TENMB")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("TRANGTHAI")
                        .HasColumnType("bit");

                    b.Property<string>("VITRI")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("MAMB");

                    b.ToTable("MatBangs");
                });

            modelBuilder.Entity("QLTTTM.models.NhanVien", b =>
                {
                    b.Property<int>("MANV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MANV"));

                    b.Property<string>("AVATAR")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DIACHI")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("GIOITINH")
                        .HasColumnType("bit");

                    b.Property<string>("HOTEN")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MACV")
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAYSINH")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NGAYVAOLAM")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("MANV");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("QLTTTM.models.PhanQuyen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("GHICHU")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MACN")
                        .HasColumnType("int");

                    b.Property<int>("MACV")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PhanQuyens");
                });

            modelBuilder.Entity("QLTTTM.models.SuKien", b =>
                {
                    b.Property<int>("MASK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MASK"));

                    b.Property<string>("IMAGEPATH")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("IMAGEPATH1")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("IMAGEPATH2")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("LOAISK")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MANV")
                        .HasColumnType("int");

                    b.Property<string>("MOTA")
                        .IsRequired()
                        .HasMaxLength(300000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TENSK")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("THOIGIAN")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("TRANGTHAI")
                        .HasColumnType("bit");

                    b.Property<string>("VITRI")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("MASK");

                    b.ToTable("SuKiens");
                });
#pragma warning restore 612, 618
        }
    }
}
