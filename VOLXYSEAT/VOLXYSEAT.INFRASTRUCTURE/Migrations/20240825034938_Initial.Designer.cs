﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VOLXYSEAT.INFRASTRUCTURE.Data;

#nullable disable

namespace VOLXYSEAT.INFRASTRUCTURE.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240825034938_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("VOLXYSEAT.DOMAIN.Models.Subscription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("StatusId");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("TypeId");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.HasKey("Id");

                    b.ToTable("Subscription", "volxyseat");
                });

            modelBuilder.Entity("VOLXYSEAT.DOMAIN.Models.SubscriptionHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .IsUnicode(false)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("VolxyseatHistory", "volxyseat");
                });

            modelBuilder.Entity("VOLXYSEAT.DOMAIN.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordConfirm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("VOLXYSEAT.DOMAIN.Models.SubscriptionHistory", b =>
                {
                    b.HasOne("VOLXYSEAT.DOMAIN.Models.Subscription", null)
                        .WithMany("Histories")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VOLXYSEAT.DOMAIN.Models.Subscription", b =>
                {
                    b.Navigation("Histories");
                });
#pragma warning restore 612, 618
        }
    }
}
