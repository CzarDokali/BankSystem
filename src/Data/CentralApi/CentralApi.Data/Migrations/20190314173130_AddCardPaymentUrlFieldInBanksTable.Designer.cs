﻿// <auto-generated />
namespace CentralApi.Data.Migrations
{
    using CentralApi.Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;

    [DbContext(typeof(CentralApiDbContext))]
    [Migration("20190314173130_AddCardPaymentUrlFieldInBanksTable")]
    partial class AddCardPaymentUrlFieldInBanksTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CentralApi.Models.Bank", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApiAddress")
                        .IsRequired();

                    b.Property<string>("ApiKey")
                        .IsRequired();

                    b.Property<string>("CardPaymentUrl");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PaymentUrl");

                    b.Property<string>("ShortName")
                        .IsRequired();

                    b.Property<string>("SwiftCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });
#pragma warning restore 612, 618
        }
    }
}