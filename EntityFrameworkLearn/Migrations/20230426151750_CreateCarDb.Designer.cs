﻿// <auto-generated />
using EntityFrameworkLearn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkLearn.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230426151750_CreateCarDb")]
    partial class CreateCarDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("EntityFrameworkLearn.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserNickname")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
