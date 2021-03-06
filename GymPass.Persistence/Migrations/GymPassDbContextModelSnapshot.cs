﻿// <auto-generated />
using System;
using GymPass.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GymPass.Persistence.Migrations
{
    [DbContext(typeof(GymPassDbContext))]
    partial class GymPassDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GymPass.Domain.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("WorkoutRoutineId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.HasIndex("WorkoutRoutineId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PaymentPeriodId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PaymentPeriodId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.PaymentPeriod", b =>
                {
                    b.Property<int>("PaymentPeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Months")
                        .HasColumnType("int");

                    b.HasKey("PaymentPeriodId");

                    b.ToTable("PaymentPeriods");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.SubRoutine", b =>
                {
                    b.Property<int>("SubRoutineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("WorkoutRoutineId")
                        .HasColumnType("int");

                    b.HasKey("SubRoutineId");

                    b.HasIndex("WorkoutRoutineId");

                    b.ToTable("SubRoutines");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.WorkoutRoutine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WorkoutRoutines");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.Client", b =>
                {
                    b.HasOne("GymPass.Domain.Entities.WorkoutRoutine", "WorkoutRoutine")
                        .WithMany("Clients")
                        .HasForeignKey("WorkoutRoutineId");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.Payment", b =>
                {
                    b.HasOne("GymPass.Domain.Entities.Client", "Client")
                        .WithMany("Payments")
                        .HasForeignKey("ClientId");

                    b.HasOne("GymPass.Domain.Entities.PaymentPeriod", "PaymentPeriod")
                        .WithMany()
                        .HasForeignKey("PaymentPeriodId");
                });

            modelBuilder.Entity("GymPass.Domain.Entities.SubRoutine", b =>
                {
                    b.HasOne("GymPass.Domain.Entities.WorkoutRoutine", null)
                        .WithMany("SubRoutines")
                        .HasForeignKey("WorkoutRoutineId");
                });
#pragma warning restore 612, 618
        }
    }
}
