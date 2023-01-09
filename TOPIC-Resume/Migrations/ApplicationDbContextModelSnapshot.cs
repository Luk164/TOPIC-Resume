﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TOPIC_Resume.Data;

#nullable disable

namespace TOPIC_Resume.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MainLib.Entities.Award", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("awarder")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Award");
                });

            modelBuilder.Entity("MainLib.Entities.Basics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("label")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("locationId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("locationId");

                    b.ToTable("Basics");
                });

            modelBuilder.Entity("MainLib.Entities.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("issuer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Certificate");
                });

            modelBuilder.Entity("MainLib.Entities.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("courses")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("endDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("institution")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("score")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("startDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("studyType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("MainLib.Entities.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string[]>("keywords")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Interest");
                });

            modelBuilder.Entity("MainLib.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("fluency")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("MainLib.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("countryCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("postalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MainLib.Entities.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BasicsId")
                        .HasColumnType("integer");

                    b.Property<string>("network")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BasicsId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("MainLib.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("endDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("entity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("highlights")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("keywords")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("roles")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("startDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("MainLib.Entities.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("publisher")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("releaseDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Publication");
                });

            modelBuilder.Entity("MainLib.Entities.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("reference")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Reference");
                });

            modelBuilder.Entity("MainLib.Entities.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BasicsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BasicsId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("MainLib.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string[]>("keywords")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("level")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("MainLib.Entities.Volunteer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("endDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("highlights")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("organization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("startDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Volunteer");
                });

            modelBuilder.Entity("MainLib.Entities.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResumeId")
                        .HasColumnType("integer");

                    b.Property<string>("endDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("highlights")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("startDate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ResumeId");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TOPIC_Resume.Entities.CustomIdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Experiment")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MainLib.Entities.Award", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("awards")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Basics", b =>
                {
                    b.HasOne("MainLib.Entities.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationId");

                    b.Navigation("location");
                });

            modelBuilder.Entity("MainLib.Entities.Certificate", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("certificates")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Education", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("education")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Interest", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("interests")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Language", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("languages")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Profile", b =>
                {
                    b.HasOne("MainLib.Entities.Basics", null)
                        .WithMany("profiles")
                        .HasForeignKey("BasicsId");
                });

            modelBuilder.Entity("MainLib.Entities.Project", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("projects")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Publication", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("publications")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Reference", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("references")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Resume", b =>
                {
                    b.HasOne("MainLib.Entities.Basics", "Basics")
                        .WithMany()
                        .HasForeignKey("BasicsId");

                    b.Navigation("Basics");
                });

            modelBuilder.Entity("MainLib.Entities.Skill", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("skills")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Volunteer", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("volunteer")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("MainLib.Entities.Work", b =>
                {
                    b.HasOne("MainLib.Entities.Resume", null)
                        .WithMany("work")
                        .HasForeignKey("ResumeId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TOPIC_Resume.Entities.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TOPIC_Resume.Entities.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TOPIC_Resume.Entities.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TOPIC_Resume.Entities.CustomIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MainLib.Entities.Basics", b =>
                {
                    b.Navigation("profiles");
                });

            modelBuilder.Entity("MainLib.Entities.Resume", b =>
                {
                    b.Navigation("awards");

                    b.Navigation("certificates");

                    b.Navigation("education");

                    b.Navigation("interests");

                    b.Navigation("languages");

                    b.Navigation("projects");

                    b.Navigation("publications");

                    b.Navigation("references");

                    b.Navigation("skills");

                    b.Navigation("volunteer");

                    b.Navigation("work");
                });
#pragma warning restore 612, 618
        }
    }
}
