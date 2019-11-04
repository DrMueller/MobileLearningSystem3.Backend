﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Mmu.Mls3.WebApi.Infrastructure.DataAccess.Repositories.Servants;

namespace Mmu.Mls3.WebApi.Infrastructure.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity(
                "Mmu.Mls3.WebApi.Areas.DataAccess.Entities.Fact",
                b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText")
                        .IsRequired();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("QuestionText")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Fact", "Core");
                });

            modelBuilder.Entity(
                "Mmu.Mls3.WebApi.Areas.DataAccess.Entities.LearningSession",
                b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OneString");

                    b.Property<string>("SessionName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("LearningSession", "Core");
                });

            modelBuilder.Entity(
                "Mmu.Mls3.WebApi.Areas.DataAccess.Entities.LearningSessionFact",
                b =>
                {
                    b.Property<long>("FactId");

                    b.Property<long>("LearningSessionId");

                    b.HasKey("FactId", "LearningSessionId");

                    b.HasIndex("LearningSessionId");

                    b.ToTable("LearningSessionFact", "Core");
                });

            modelBuilder.Entity(
                "Mmu.Mls3.WebApi.Infrastructure.Security.DataAccess.Entities.AppUser",
                b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AppUser", "Security");
                });

            modelBuilder.Entity(
                "Mmu.Mls3.WebApi.Areas.DataAccess.Entities.LearningSessionFact",
                b =>
                {
                    b.HasOne("Mmu.Mls3.WebApi.Areas.DataAccess.Entities.Fact", "Fact")
                        .WithMany("LearningSessionFacts")
                        .HasForeignKey("FactId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Mmu.Mls3.WebApi.Areas.DataAccess.Entities.LearningSession", "LearningSession")
                        .WithMany("LearningSessionFacts")
                        .HasForeignKey("LearningSessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}