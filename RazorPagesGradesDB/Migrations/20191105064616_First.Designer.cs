﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesGrades.Models;

namespace RazorPagesGrades.Migrations
{
    [DbContext(typeof(GradesContext))]
    [Migration("20191105064616_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("RazorPagesGrades.Models.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SubjectAcronym")
                        .IsRequired();

                    b.Property<double>("Value");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("SubjectAcronym");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("RazorPagesGrades.Models.Subject", b =>
                {
                    b.Property<string>("Acronym")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3);

                    b.Property<string>("Name");

                    b.HasKey("Acronym");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("RazorPagesGrades.Models.Grade", b =>
                {
                    b.HasOne("RazorPagesGrades.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectAcronym")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
