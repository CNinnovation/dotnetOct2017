﻿// <auto-generated />
using EFCoreSample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EFCoreSample.Migrations
{
    [DbContext(typeof(BooksContext))]
    partial class BooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreSample.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Isbn")
                        .HasMaxLength(20);

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Title")
                        .HasMaxLength(60);

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
