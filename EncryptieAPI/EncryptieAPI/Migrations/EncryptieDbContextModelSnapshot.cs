﻿// <auto-generated />
using System;
using EncryptieAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EncryptieAPI.Migrations
{
    [DbContext(typeof(EncryptieDbContext))]
    partial class EncryptieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EncryptieAPI.Models.Bericht", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("aanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("encryptedBericht")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isVervalt")
                        .HasColumnType("bit");

                    b.Property<int>("vervalDatum")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Berichten");
                });
#pragma warning restore 612, 618
        }
    }
}
