﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudyProject.Identity.Database;

namespace StudyProject.Identity.API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190807134859_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("StudyProject.Identity.Database.Models.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("Guid");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Guid = new Guid("af81e6f7-42dd-42e8-83f1-bd5a8fd4c6e5"),
                            Login = "admin@gmail.com",
                            Password = "AQAAAAEAACcQAAAAECaPpK4il2VcAuvlKCjAOF3L/7PKpFVheMkMfw2xdgnDX6GHAh5Py0gdTgx9kpN7SQ=="
                        },
                        new
                        {
                            Guid = new Guid("88eda3d7-edb2-434c-b781-95aeeadcdc89"),
                            Login = "qwerty",
                            Password = "AQAAAAEAACcQAAAAEA7WMtKRrPVg4avuUaFoOXg2bc3QfDJOIH3GgFtenYsjZWSEYlsjpkqapzRpw56EbA=="
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
