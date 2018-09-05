﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnBoarding.Models;

namespace OnBoarding.Migrations
{
    [DbContext(typeof(OnBoardingContext))]
    [Migration("20180904070748_updatedlatest")]
    partial class updatedlatest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnBoarding.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("Phone_no");

                    b.Property<string>("Profile_img_url");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Agent");
                });

            modelBuilder.Entity("OnBoarding.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Customer_name");

                    b.Property<string>("Email");

                    b.Property<string>("Logo_url");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OnBoarding.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName");

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("OnBoarding.Models.EndUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.Property<string>("Phone_no");

                    b.Property<string>("Profile_img_url");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("EndUser");
                });

            modelBuilder.Entity("OnBoarding.Models.UserSocialId", b =>
                {
                    b.Property<int>("SocialId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EndUserId");

                    b.Property<string>("Identifier");

                    b.Property<string>("Source");

                    b.HasKey("SocialId");

                    b.HasIndex("EndUserId");

                    b.ToTable("UserSocialId");
                });

            modelBuilder.Entity("OnBoarding.Models.Agent", b =>
                {
                    b.HasOne("OnBoarding.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("OnBoarding.Models.Customer", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("OnBoarding.Models.EndUser", b =>
                {
                    b.HasOne("OnBoarding.Models.Customer", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("OnBoarding.Models.UserSocialId", b =>
                {
                    b.HasOne("OnBoarding.Models.EndUser")
                        .WithMany("SocialId")
                        .HasForeignKey("EndUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
