﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackOverflowTagsAPI.Database;

#nullable disable

namespace TagsAPI.Migrations
{
    [DbContext(typeof(TagsDbContext))]
    [Migration("20240811160226_Rename2")]
    partial class Rename2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StackOverflowTagsAPI.Models.Collective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("Collectives");
                });

            modelBuilder.Entity("StackOverflowTagsAPI.Models.CollectiveExternalLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CollectiveId")
                        .HasColumnType("int");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollectiveId");

                    b.ToTable("ExternalLinks");
                });

            modelBuilder.Entity("StackOverflowTagsAPI.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<bool>("has_synonyms")
                        .HasColumnType("bit");

                    b.Property<bool>("is_moderator_only")
                        .HasColumnType("bit");

                    b.Property<bool>("is_required")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("StackOverflowTagsAPI.Models.Collective", b =>
                {
                    b.HasOne("StackOverflowTagsAPI.Models.Tag", null)
                        .WithMany("Collectives")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("StackOverflowTagsAPI.Models.CollectiveExternalLink", b =>
                {
                    b.HasOne("StackOverflowTagsAPI.Models.Collective", null)
                        .WithMany("external_links")
                        .HasForeignKey("CollectiveId");
                });

            modelBuilder.Entity("StackOverflowTagsAPI.Models.Collective", b =>
                {
                    b.Navigation("external_links");
                });

            modelBuilder.Entity("StackOverflowTagsAPI.Models.Tag", b =>
                {
                    b.Navigation("Collectives");
                });
#pragma warning restore 612, 618
        }
    }
}
