﻿// <auto-generated />
using ASP.NET_Core_Identity_Tutorial.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET_Core_Identity_Tutorial.Migrations
{
    [DbContext(typeof(ASPNET_Core_Identity_TutorialContext))]
    [Migration("20211117145237_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NET_Core_Identity_Tutorial.Models.Employee", b =>
                {
                    b.Property<string>("BID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BID");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
