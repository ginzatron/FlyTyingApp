﻿// <auto-generated />
using System;
using FlyCreator.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlyCreatorInEntity.Migrations
{
    [DbContext(typeof(FlyDbContext))]
    [Migration("20200408035345_04_07_2020_Add_MaterialOptions")]
    partial class _04_07_2020_Add_MaterialOptions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlyCreatorInEntity.Models.FlyClassification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlyClassifications");
                });

            modelBuilder.Entity("FlyCreatorInEntity.Models.MaterialCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaterialCategories");
                });

            modelBuilder.Entity("FlyCreatorInEntity.Models.MaterialOptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("MaterialOptions");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlyId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlyId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("SectionId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Fly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassificationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.ToTable("Flys");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FlyClassificationId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FlyClassificationId");

                    b.HasIndex("MaterialCategoryId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("FlyCreatorInEntity.Models.MaterialOptions", b =>
                {
                    b.HasOne("FlyCreatorWithEntity.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Component", b =>
                {
                    b.HasOne("FlyCreatorWithEntity.Models.Fly", null)
                        .WithMany("Components")
                        .HasForeignKey("FlyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyCreatorWithEntity.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId");

                    b.HasOne("FlyCreatorWithEntity.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Fly", b =>
                {
                    b.HasOne("FlyCreatorInEntity.Models.FlyClassification", "Classification")
                        .WithMany()
                        .HasForeignKey("ClassificationId");
                });

            modelBuilder.Entity("FlyCreatorWithEntity.Models.Material", b =>
                {
                    b.HasOne("FlyCreatorInEntity.Models.FlyClassification", "FlyClassification")
                        .WithMany()
                        .HasForeignKey("FlyClassificationId");

                    b.HasOne("FlyCreatorInEntity.Models.MaterialCategory", "MaterialCategory")
                        .WithMany()
                        .HasForeignKey("MaterialCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
