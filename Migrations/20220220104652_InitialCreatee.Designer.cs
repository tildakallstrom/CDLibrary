﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using appmom3.Data;

#nullable disable

namespace appmom3.Migrations
{
    [DbContext(typeof(CdContext))]
    [Migration("20220220104652_InitialCreatee")]
    partial class InitialCreatee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("appmom3.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("appmom3.Models.Cd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Cd");
                });

            modelBuilder.Entity("appmom3.Models.Cd", b =>
                {
                    b.HasOne("appmom3.Models.Artist", "Artist")
                        .WithMany("Cds")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("appmom3.Models.Artist", b =>
                {
                    b.Navigation("Cds");
                });
#pragma warning restore 612, 618
        }
    }
}
