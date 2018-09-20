﻿// <auto-generated />
using System;
using GroupApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupApp.Migrations
{
    [DbContext(typeof(GroupAppContext))]
    partial class GroupAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroupApp.Models.CentralLocations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateTime");
<<<<<<< HEAD
<<<<<<< HEAD
=======

                    b.Property<string>("Establishment");
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
=======
>>>>>>> fb9284e99864479f00fb130461a796798f43899e

                    b.Property<string>("Establishment")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Thoughts");

                    b.HasKey("Id");

                    b.ToTable("CentralLocations");
                });

            modelBuilder.Entity("GroupApp.Models.NorthLocations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateTime");
<<<<<<< HEAD
<<<<<<< HEAD
=======

                    b.Property<string>("Establishment");
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
=======
>>>>>>> fb9284e99864479f00fb130461a796798f43899e

                    b.Property<string>("Establishment")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Thoughts");

                    b.HasKey("Id");

                    b.ToTable("NorthLocations");
                });

            modelBuilder.Entity("GroupApp.Models.SouthLocations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateTime");
<<<<<<< HEAD
<<<<<<< HEAD
=======

                    b.Property<string>("Establishment");
>>>>>>> a0d5ffb9d521ed06ad223332783a39f144db96f2
=======
>>>>>>> fb9284e99864479f00fb130461a796798f43899e

                    b.Property<string>("Establishment")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Thoughts");

                    b.HasKey("Id");

                    b.ToTable("SouthLocations");
                });

            modelBuilder.Entity("GroupApp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("First");

                    b.Property<string>("Last");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
        }
    }
}
