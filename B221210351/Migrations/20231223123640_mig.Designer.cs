﻿// <auto-generated />
using System;
using B221210351.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace B221210351.Migrations
{
    [DbContext(typeof(HastaneContext))]
    [Migration("20231223123640_mig")]
    partial class mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("B221210351.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<int>("ApartmentNo")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("NeighbourhoodId")
                        .HasColumnType("int");

                    b.Property<int>("StreetId")
                        .HasColumnType("int");

                    b.HasKey("AddressId");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("NeighbourhoodId");

                    b.HasIndex("StreetId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("B221210351.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("B221210351.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"), 1L, 1);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PoliclinicId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PoliclinicId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("B221210351.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("B221210351.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("B221210351.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"), 1L, 1);

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("B221210351.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<int>("PoliclinicId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("PoliclinicId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("B221210351.Models.Neighbourhood", b =>
                {
                    b.Property<int>("NeighbourhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NeighbourhoodId"), 1L, 1);

                    b.Property<string>("NeighbourhoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NeighbourhoodId");

                    b.ToTable("Neighbourhoods");
                });

            modelBuilder.Entity("B221210351.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PatientBirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("PatientEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PatientGender")
                        .HasColumnType("bit");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientPersonalId")
                        .HasColumnType("int");

                    b.Property<string>("PatientSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.HasIndex("AddressId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("B221210351.Models.Policlinic", b =>
                {
                    b.Property<int>("PoliclinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoliclinicId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("PoliclinicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoliclinicId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Policlinics");
                });

            modelBuilder.Entity("B221210351.Models.Street", b =>
                {
                    b.Property<int>("StreetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StreetId"), 1L, 1);

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StreetId");

                    b.ToTable("Street");
                });

            modelBuilder.Entity("B221210351.Models.Address", b =>
                {
                    b.HasOne("B221210351.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B221210351.Models.District", "District")
                        .WithMany("Addresses")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B221210351.Models.Neighbourhood", "Neighbourhood")
                        .WithMany("Addresses")
                        .HasForeignKey("NeighbourhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B221210351.Models.Street", "Street")
                        .WithMany("Addresses")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("District");

                    b.Navigation("Neighbourhood");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("B221210351.Models.Appointment", b =>
                {
                    b.HasOne("B221210351.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("B221210351.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("B221210351.Models.Policlinic", "Policlinic")
                        .WithMany("Appointments")
                        .HasForeignKey("PoliclinicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("B221210351.Models.Doctor", b =>
                {
                    b.HasOne("B221210351.Models.Policlinic", "Policlinic")
                        .WithMany("Doctors")
                        .HasForeignKey("PoliclinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("B221210351.Models.Patient", b =>
                {
                    b.HasOne("B221210351.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("B221210351.Models.Policlinic", b =>
                {
                    b.HasOne("B221210351.Models.Department", "Department")
                        .WithMany("Policlinics")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("B221210351.Models.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("B221210351.Models.Department", b =>
                {
                    b.Navigation("Policlinics");
                });

            modelBuilder.Entity("B221210351.Models.District", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("B221210351.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("B221210351.Models.Neighbourhood", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("B221210351.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("B221210351.Models.Policlinic", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("B221210351.Models.Street", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
