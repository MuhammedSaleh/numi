﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using numi.src.domain.Data;

#nullable disable

namespace numi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("numi.src.domain.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "001",
                            Name = "Dreamy"
                        },
                        new
                        {
                            CategoryId = "002",
                            Name = "Sky"
                        },
                        new
                        {
                            CategoryId = "003",
                            Name = "Sky Pillowtop"
                        },
                        new
                        {
                            CategoryId = "004",
                            Name = "Aqua Memory"
                        },
                        new
                        {
                            CategoryId = "005",
                            Name = "Calma"
                        });
                });

            modelBuilder.Entity("numi.src.domain.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dimension")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = "01010010001",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "90x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010002",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "100x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010003",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "110x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010004",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "120x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010005",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "140x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010006",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "150x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010007",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "160x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010008",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "180x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010010009",
                            CategoryId = "001",
                            Description = "Dreamy Connected Pocket Height 23CM",
                            Dimension = "200x200",
                            Name = "Dreamy"
                        },
                        new
                        {
                            ProductId = "01010020001",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "90x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020002",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "100x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020003",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "110x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020004",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "120x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020005",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "140x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020006",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "150x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020007",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "160x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020008",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "180x200",
                            Name = "Sky"
                        },
                        new
                        {
                            ProductId = "01010020009",
                            CategoryId = "002",
                            Description = "Sky Connected Pocket 26CM",
                            Dimension = "200x200",
                            Name = "Sky"
                        });
                });

            modelBuilder.Entity("numi.src.domain.Models.Product", b =>
                {
                    b.HasOne("numi.src.domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("numi.src.domain.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
