﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MojecHRApp.DAL;

#nullable disable

namespace MojecHRApp.Migrations
{
    [DbContext(typeof(HRDbContext))]
    [Migration("20220912000442_newdoc")]
    partial class newdoc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MojecHRApp.Models.EmailsTbl", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("EmailsTbl");
                });

            modelBuilder.Entity("MojecHRApp.Models.Experience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("MojecHRApp.Models.Files", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("MojecHRApp.Models.LoginTbl", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("LoginTbl");
                });

            modelBuilder.Entity("MojecHRApp.Models.StaffDetails", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffID"), 1L, 1);

                    b.Property<string>("AidForWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Allergy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentDesignation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfEntry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfIssues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesignationPointOfEntry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HMOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HMOOrg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HealthIssues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDExpiryDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IDNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IllnessInPast12Months")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalGoverment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middlename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKCurrentNationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKDateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKEmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKFamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKHomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOKPreviousNationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextOfKinFullname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoOfChildren")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentHouseAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfIssues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseDob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseNationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpousePresentWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseProffession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffID");

                    b.ToTable("StaffDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
