﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication4.Data;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Token", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Tokes");
                });

            modelBuilder.Entity("WebApplication2.Models.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("RecieverWalletId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderWalletId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TokenId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RecieverWalletId");

                    b.HasIndex("SenderWalletId");

                    b.HasIndex("TokenId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication2.Models.Wallet", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TokenId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<string>("WalletLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TokenId");

                    b.HasIndex("UserId");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("WebApplication2.Models.Transaction", b =>
                {
                    b.HasOne("WebApplication2.Models.Wallet", "RecieverWallet")
                        .WithMany()
                        .HasForeignKey("RecieverWalletId");

                    b.HasOne("WebApplication2.Models.Wallet", "SenderWallet")
                        .WithMany()
                        .HasForeignKey("SenderWalletId");

                    b.HasOne("WebApplication2.Models.Token", "Token")
                        .WithMany()
                        .HasForeignKey("TokenId");

                    b.Navigation("RecieverWallet");

                    b.Navigation("SenderWallet");

                    b.Navigation("Token");
                });

            modelBuilder.Entity("WebApplication2.Models.Wallet", b =>
                {
                    b.HasOne("WebApplication2.Models.Token", "Token")
                        .WithMany()
                        .HasForeignKey("TokenId");

                    b.HasOne("WebApplication2.Models.User", "User")
                        .WithMany("Wallets")
                        .HasForeignKey("UserId");

                    b.Navigation("Token");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication2.Models.User", b =>
                {
                    b.Navigation("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
