// <auto-generated />
using System;
using Data.EF.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20211201002754_AddJenre")]
    partial class AddJenre
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookStore.BaseObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Hidden")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Rowversion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.ToTable("BaseObjects");
                });

            modelBuilder.Entity("BookStore.Entities.BaseObjects.TypeObject", b =>
                {
                    b.HasBaseType("BookStore.BaseObject");

                    b.Property<DateTime?>("CreateDay")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isArchived")
                        .HasColumnType("bit");

                    b.ToTable("TypeObjects");
                });

            modelBuilder.Entity("BookStore.Entities.BaseObjects.DictObject", b =>
                {
                    b.HasBaseType("BookStore.Entities.BaseObjects.TypeObject");

                    b.ToTable("DictObjects");
                });

            modelBuilder.Entity("BookStore.Entities.BaseObjects.ProductObject", b =>
                {
                    b.HasBaseType("BookStore.Entities.BaseObjects.TypeObject");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.ToTable("ProductObjects");
                });

            modelBuilder.Entity("BookStore.Entities.BookAdditionals.Jenre", b =>
                {
                    b.HasBaseType("BookStore.Entities.BaseObjects.DictObject");

                    b.ToTable("Jenres");
                });

            modelBuilder.Entity("BookStore.Entities.Products.Book", b =>
                {
                    b.HasBaseType("BookStore.Entities.BaseObjects.ProductObject");

                    b.Property<int?>("Circulation")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<int?>("YearOfPublishing")
                        .HasColumnType("int");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookStore.Entities.BaseObjects.TypeObject", b =>
                {
                    b.HasOne("BookStore.BaseObject", null)
                        .WithOne()
                        .HasForeignKey("BookStore.Entities.BaseObjects.TypeObject", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Entities.BaseObjects.DictObject", b =>
                {
                    b.HasOne("BookStore.Entities.BaseObjects.TypeObject", null)
                        .WithOne()
                        .HasForeignKey("BookStore.Entities.BaseObjects.DictObject", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Entities.BaseObjects.ProductObject", b =>
                {
                    b.HasOne("BookStore.Entities.BaseObjects.TypeObject", null)
                        .WithOne()
                        .HasForeignKey("BookStore.Entities.BaseObjects.ProductObject", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Entities.BookAdditionals.Jenre", b =>
                {
                    b.HasOne("BookStore.Entities.BaseObjects.DictObject", null)
                        .WithOne()
                        .HasForeignKey("BookStore.Entities.BookAdditionals.Jenre", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Entities.Products.Book", b =>
                {
                    b.HasOne("BookStore.Entities.BaseObjects.ProductObject", null)
                        .WithOne()
                        .HasForeignKey("BookStore.Entities.Products.Book", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
