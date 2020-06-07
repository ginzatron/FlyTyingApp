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
    [Migration("20200606195725_addUserIdToFly")]
    partial class addUserIdToFly
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlyCreator.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialOptionId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlyId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("MaterialOptionId");

                    b.HasIndex("SectionId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("FlyCreator.Models.Fly", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassificationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEdited")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClassificationId");

                    b.ToTable("Flys");
                });

            modelBuilder.Entity("FlyCreator.Models.FlyClassification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlyClassifications");
                });

            modelBuilder.Entity("FlyCreator.Models.Material", b =>
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

            modelBuilder.Entity("FlyCreator.Models.MaterialCategory", b =>
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

            modelBuilder.Entity("FlyCreator.Models.MaterialOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("MaterialOptions");
                });

            modelBuilder.Entity("FlyCreator.Models.Section", b =>
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

            modelBuilder.Entity("FlyCreator.Models.UserNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserNotes");
                });

            modelBuilder.Entity("FlyCreator.Models.Component", b =>
                {
                    b.HasOne("FlyCreator.Models.Fly", null)
                        .WithMany("Components")
                        .HasForeignKey("FlyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyCreator.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyCreator.Models.MaterialOption", "MaterialOption")
                        .WithMany()
                        .HasForeignKey("MaterialOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlyCreator.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FlyCreator.Models.Fly", b =>
                {
                    b.HasOne("FlyCreator.Models.FlyClassification", "Classification")
                        .WithMany()
                        .HasForeignKey("ClassificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FlyCreator.Models.Material", b =>
                {
                    b.HasOne("FlyCreator.Models.FlyClassification", "FlyClassification")
                        .WithMany()
                        .HasForeignKey("FlyClassificationId");

                    b.HasOne("FlyCreator.Models.MaterialCategory", "MaterialCategory")
                        .WithMany()
                        .HasForeignKey("MaterialCategoryId");
                });

            modelBuilder.Entity("FlyCreator.Models.MaterialOption", b =>
                {
                    b.HasOne("FlyCreator.Models.Material", null)
                        .WithMany("MaterialOptions")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}