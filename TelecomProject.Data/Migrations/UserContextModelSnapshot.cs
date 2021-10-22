﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelecomProject.Data;

namespace TelecomProject.Data.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TelecomProject.Domain.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("Phone_number")
                        .HasColumnType("int");

                    b.Property<string>("Phone_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Plan_nameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("Plan_nameId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("TelecomProject.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TelecomProject.Domain.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Device_limit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("TelecomProject.Domain.Device", b =>
                {
                    b.HasOne("TelecomProject.Domain.Person", "Person")
                        .WithMany("Devices")
                        .HasForeignKey("PersonId");

                    b.HasOne("TelecomProject.Domain.Plan", "Plan_name")
                        .WithMany()
                        .HasForeignKey("Plan_nameId");

                    b.Navigation("Person");

                    b.Navigation("Plan_name");
                });

            modelBuilder.Entity("TelecomProject.Domain.Plan", b =>
                {
                    b.HasOne("TelecomProject.Domain.Person", "Person")
                        .WithMany("Plans")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("TelecomProject.Domain.Person", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("Plans");
                });
#pragma warning restore 612, 618
        }
    }
}
