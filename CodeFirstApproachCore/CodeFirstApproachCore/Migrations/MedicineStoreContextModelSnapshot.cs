﻿// <auto-generated />
using CodeFirstApproachCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstApproachCore.Migrations
{
    [DbContext(typeof(MedicineStoreContext))]
    partial class MedicineStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeFirstApproachCore.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"));

                    b.Property<string>("MedicineDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MedicinePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MedicineSupplierSupplierId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("MedicineId");

                    b.HasIndex("MedicineSupplierSupplierId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("CodeFirstApproachCore.Models.MedicineSupplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"));

                    b.Property<string>("ContactDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("MedicineSupplier");
                });

            modelBuilder.Entity("CodeFirstApproachCore.Models.Medicine", b =>
                {
                    b.HasOne("CodeFirstApproachCore.Models.MedicineSupplier", "MedicineSupplier")
                        .WithMany()
                        .HasForeignKey("MedicineSupplierSupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicineSupplier");
                });
#pragma warning restore 612, 618
        }
    }
}
