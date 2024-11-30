﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechCareer.DataAccess.Contexts;

#nullable disable

namespace TechCareer.DataAccess.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20241130164135_instructor")]
    partial class instructor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Security.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordSalt");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("Status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Techcareer",
                            PasswordHash = new byte[] { 188, 171, 241, 189, 247, 38, 234, 208, 39, 128, 45, 59, 27, 135, 2, 126, 8, 22, 38, 167, 116, 228, 83, 229, 227, 69, 34, 61, 118, 232, 186, 152, 241, 132, 87, 30, 44, 59, 228, 179, 31, 68, 131, 175, 185, 227, 26, 176, 233, 105, 243, 183, 175, 13, 194, 141, 45, 231, 219, 53, 88, 118, 61, 77 },
                            PasswordSalt = new byte[] { 83, 42, 49, 251, 106, 178, 20, 13, 75, 250, 53, 134, 168, 107, 130, 22, 150, 0, 29, 231, 205, 184, 250, 17, 140, 125, 126, 28, 203, 123, 218, 143, 177, 172, 188, 222, 247, 160, 79, 120, 182, 215, 121, 84, 178, 191, 11, 69, 127, 156, 7, 39, 246, 73, 22, 86, 5, 225, 195, 70, 45, 189, 59, 211, 247, 0, 242, 29, 203, 167, 39, 201, 9, 252, 232, 213, 18, 31, 252, 203, 37, 16, 88, 12, 197, 148, 26, 13, 113, 88, 5, 254, 223, 155, 253, 200, 224, 0, 15, 214, 109, 202, 96, 220, 136, 87, 96, 231, 145, 53, 4, 10, 58, 79, 37, 210, 90, 140, 76, 34, 91, 89, 206, 215, 145, 252, 203, 244 },
                            Status = true
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int")
                        .HasColumnName("OperationClaimId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OperationClaimId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TechCareer.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TechCareer.Models.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("ApplicationDeadline")
                        .HasColumnType("datetime2")
                        .HasColumnName("ApplicationDeadline");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EndDate");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("ParticipationText")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("ParticipationText");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("StartDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Title");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events", (string)null);
                });

            modelBuilder.Entity("TechCareer.Models.Entities.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("About");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("TechCareer.Models.Entities.VideoEducation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDate");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedDate");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImageUrl");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("InstructorId");

                    b.Property<bool>("IsCertified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("IsCertified");

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("Level");

                    b.Property<string>("ProgrammingLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProgrammingLanguage");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.Property<double>("TotalHour")
                        .HasColumnType("float")
                        .HasColumnName("TotalHour");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("VideoEducations", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Security.Entities.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechCareer.Models.Entities.Event", b =>
                {
                    b.HasOne("TechCareer.Models.Entities.Category", "CategoryName")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CategoryName");
                });

            modelBuilder.Entity("TechCareer.Models.Entities.VideoEducation", b =>
                {
                    b.HasOne("TechCareer.Models.Entities.Instructor", "Instructor")
                        .WithMany("VideoEducations")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Core.Security.Entities.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("TechCareer.Models.Entities.Category", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("TechCareer.Models.Entities.Instructor", b =>
                {
                    b.Navigation("VideoEducations");
                });
#pragma warning restore 612, 618
        }
    }
}
