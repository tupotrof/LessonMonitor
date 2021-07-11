﻿// <auto-generated />
using System;
using LessonMonitor.DataAccess.MSSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LessonMonitor.DataAccess.MSSQL.Migrations
{
    [DbContext(typeof(LessonMonitorDbContext))]
    [Migration("20210711165530_RemoveReferences")]
    partial class RemoveReferences
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LessonMonitor.DataAccess.MSSQL.Entities.GithubAccount", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<Guid>("GithubAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("MemberId");

                    b.ToTable("GithubAccounts");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.MSSQL.Entities.Homework", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.MSSQL.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("HomeworkId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Lessons");

                    b.ToView("LessonsView");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.MSSQL.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("YouTubeUserId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.MSSQL.Entities.GithubAccount", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.MSSQL.Entities.Member", "Member")
                        .WithOne("GithubAccount")
                        .HasForeignKey("LessonMonitor.DataAccess.MSSQL.Entities.GithubAccount", "MemberId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.MSSQL.Entities.Member", b =>
                {
                    b.Navigation("GithubAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
