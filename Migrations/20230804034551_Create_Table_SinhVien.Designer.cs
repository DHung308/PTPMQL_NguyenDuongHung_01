﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenDuongHung_01.Data;

#nullable disable

namespace NguyenDuongHung_01.Migrations
{
    [DbContext(typeof(NguyenDuongHung_01Context))]
    [Migration("20230804034551_Create_Table_SinhVien")]
    partial class Create_Table_SinhVien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("NguyenDuongHung_01.Models.LopHoc", b =>
                {
                    b.Property<string>("Malop")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Malop");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("NguyenDuongHung_01.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSinhVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .HasColumnType("TEXT");

                    b.Property<string>("Malop")
                        .HasColumnType("TEXT");

                    b.HasKey("MaSinhVien");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
