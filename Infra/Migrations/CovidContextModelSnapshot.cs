﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(CovidContext))]
    partial class CovidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Countries.Country", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<double>("ActiveCases")
                        .HasColumnType("double");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.Property<string>("LastUpdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NewCases")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NewDeaths")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TotalCases")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TotalDeaths")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TotalRecovered")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CountryName")
                        .IsUnique();

                    b.ToTable("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
