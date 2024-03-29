﻿// <auto-generated />
using Asp.netCoreMVCIntro.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp.netCoreMVCIntro.Migrations
{
    [DbContext(typeof(TutorialDbContext))]
    [Migration("20230202054555_New")]
    partial class New
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"), 1L, 1);

                    b.Property<string>("ArticleContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TutorialId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId");

                    b.HasIndex("TutorialId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            ArticleContent = "C# is an Object oriented language",
                            ArticleTitle = "Introduction to C#",
                            TutorialId = 1
                        });
                });

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Tutorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tutorials");
                });

            modelBuilder.Entity("Asp.netCoreMVCIntro.Models.Article", b =>
                {
                    b.HasOne("Asp.netCoreMVCIntro.Models.Tutorial", "Tutorial")
                        .WithMany()
                        .HasForeignKey("TutorialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tutorial");
                });
#pragma warning restore 612, 618
        }
    }
}
