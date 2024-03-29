﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SignalRChat.DataAccess;

#nullable disable

namespace SignalRChat.Migrations;

[DbContext(typeof(ChatContext))]
partial class ChatContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("SignalRChat.DataAccess.ApplicationUser", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnType("nvarchar(16)");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnType("nvarchar(25)");

                b.HasKey("Id");

                b.ToTable("ApplicationUsers");
            });
#pragma warning restore 612, 618
    }
}
