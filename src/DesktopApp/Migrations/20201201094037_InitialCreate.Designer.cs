﻿// <auto-generated />
using System;
using DesktopApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesktopApp.Migrations
{
    [DbContext(typeof(ShellFishDbContext))]
    [Migration("20201201094037_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AssetTag", b =>
                {
                    b.Property<int>("AssetsAssetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AssetsAssetId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("AssetTag");
                });

            modelBuilder.Entity("DesktopApp.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("AssetId");

                    b.ToTable("Assets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Asset");
                });

            modelBuilder.Entity("DesktopApp.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Website")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("DesktopApp.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("DesktopApp.Models.Blogpost", b =>
                {
                    b.HasBaseType("DesktopApp.Models.Asset");

                    b.Property<int?>("AuthorPersonId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("TEXT");

                    b.HasIndex("AuthorPersonId");

                    b.HasDiscriminator().HasValue("Blogpost");
                });

            modelBuilder.Entity("DesktopApp.Models.Book", b =>
                {
                    b.HasBaseType("DesktopApp.Models.Asset");

                    b.Property<int?>("AuthorPersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Book_AuthorPersonId");

                    b.Property<string>("Cover")
                        .HasColumnType("TEXT");

                    b.Property<string>("Edition")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileType")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TEXT");

                    b.HasIndex("AuthorPersonId");

                    b.HasDiscriminator().HasValue("Book");
                });

            modelBuilder.Entity("DesktopApp.Models.Podcast", b =>
                {
                    b.HasBaseType("DesktopApp.Models.Asset");

                    b.Property<int>("Episode")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Length")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("Podcast_PublishDate");

                    b.Property<int?>("SpeakerPersonId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("SpeakerPersonId");

                    b.HasDiscriminator().HasValue("Podcast");
                });

            modelBuilder.Entity("DesktopApp.Models.Slide", b =>
                {
                    b.HasBaseType("DesktopApp.Models.Asset");

                    b.Property<string>("Event")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileType")
                        .HasColumnType("TEXT")
                        .HasColumnName("Slide_FileType");

                    b.Property<int?>("SpeakerPersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Slide_SpeakerPersonId");

                    b.HasIndex("SpeakerPersonId");

                    b.HasDiscriminator().HasValue("Slide");
                });

            modelBuilder.Entity("DesktopApp.Models.Video", b =>
                {
                    b.HasBaseType("DesktopApp.Models.Asset");

                    b.Property<float>("Length")
                        .HasColumnType("REAL")
                        .HasColumnName("Video_Length");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("Video_UploadDate");

                    b.Property<int?>("UploaderPersonId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("UploaderPersonId");

                    b.HasDiscriminator().HasValue("Video");
                });

            modelBuilder.Entity("AssetTag", b =>
                {
                    b.HasOne("DesktopApp.Models.Asset", null)
                        .WithMany()
                        .HasForeignKey("AssetsAssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesktopApp.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DesktopApp.Models.Blogpost", b =>
                {
                    b.HasOne("DesktopApp.Models.Person", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorPersonId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DesktopApp.Models.Book", b =>
                {
                    b.HasOne("DesktopApp.Models.Person", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorPersonId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("DesktopApp.Models.Podcast", b =>
                {
                    b.HasOne("DesktopApp.Models.Person", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerPersonId");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("DesktopApp.Models.Slide", b =>
                {
                    b.HasOne("DesktopApp.Models.Person", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerPersonId");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("DesktopApp.Models.Video", b =>
                {
                    b.HasOne("DesktopApp.Models.Person", "Uploader")
                        .WithMany()
                        .HasForeignKey("UploaderPersonId");

                    b.Navigation("Uploader");
                });
#pragma warning restore 612, 618
        }
    }
}
