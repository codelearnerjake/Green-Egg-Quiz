﻿// <auto-generated />
using Green_Egg_Quiz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Green_Egg_Quiz.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210803224947_SeedDataAdded")]
    partial class SeedDataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Green_Egg_Quiz.Models.QuestionAndAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Answer1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CorrectAnswer")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionsAndAnswers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer1 = "Mt. Fiji",
                            Answer2 = "Mt. Everest",
                            Answer3 = "Mt. Olympus",
                            CorrectAnswer = 2,
                            Question = "What is the tallest mountian on earth?"
                        },
                        new
                        {
                            Id = 2,
                            Answer1 = "Mauna Kea",
                            Answer2 = "Monte Pico",
                            Answer3 = "Aconcagua",
                            CorrectAnswer = 1,
                            Question = "What is the tallest mountian under the ocean?"
                        },
                        new
                        {
                            Id = 3,
                            Answer1 = "Ad Solem on Jupiter",
                            Answer2 = "Mt. Everest on Earth",
                            Answer3 = "Olympus Mons on Mars",
                            CorrectAnswer = 3,
                            Question = "What is the tallest mountian in the solar system?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}