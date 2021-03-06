﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YugiohGanda.Core.Data;

namespace YugiohGanda.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210408223436_databaseupdate")]
    partial class databaseupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cards");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Card");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.DeckCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("DeckId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DeckId");

                    b.ToTable("DeckCards");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Duel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DuelStatus")
                        .HasColumnType("int");

                    b.Property<string>("Player1Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Player1Life")
                        .HasColumnType("int");

                    b.Property<string>("Player2Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Player2Life")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Player1Id");

                    b.HasIndex("Player2Id");

                    b.ToTable("Duels");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.DuelCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("DuelCardStatus")
                        .HasColumnType("int");

                    b.Property<int>("DuelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("DuelId");

                    b.ToTable("DuelCards");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentDeckId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CurrentDeckId")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Monster", b =>
                {
                    b.HasBaseType("YugiohGanda.Core.Models.Card");

                    b.Property<int>("AttackPoints")
                        .HasColumnType("int");

                    b.Property<int>("DefensePoints")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MonsterAttribute")
                        .HasColumnType("int");

                    b.Property<int>("MonsterType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Monster");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "An elf who learned to wield a sword, he baffles enemies with lightning - swift attacks.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/91152256.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/91152256.jpg",
                            Name = "Celtic Guardian",
                            Price = 1000,
                            AttackPoints = 1400,
                            DefensePoints = 1200,
                            Level = 4,
                            MonsterAttribute = 2,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 2,
                            Description = "With skin tinged a bluish-white, this strange creature is a fearsome sight to behold.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/21263083.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/21263083.jpg",
                            Name = "Pale Beast",
                            Price = 1200,
                            AttackPoints = 1500,
                            DefensePoints = 1200,
                            Level = 4,
                            MonsterAttribute = 2,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Much more than just a child, this dragon is gifted with untapped power.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/88819587.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/88819587.jpg",
                            Name = "Baby Dragon",
                            Price = 900,
                            AttackPoints = 1200,
                            DefensePoints = 700,
                            Level = 3,
                            MonsterAttribute = 6,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 4,
                            Description = "A monster with tremendous power, it destroys enemies with a swing of its axe.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/5053103.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/5053103.jpg",
                            Name = "Battle Ox",
                            Price = 1400,
                            AttackPoints = 1700,
                            DefensePoints = 1000,
                            Level = 4,
                            MonsterAttribute = 2,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Elf twins that alternate their attacks.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/69140098.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/69140098.jpg",
                            Name = "Gemini Elf",
                            Price = 1600,
                            AttackPoints = 1900,
                            DefensePoints = 900,
                            Level = 4,
                            MonsterAttribute = 2,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 6,
                            Description = "This wicked Beast-Warrior does every horrid thing imaginable, and loves it! His axe bears the marks of his countless victims.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/14898066.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/14898066.jpg",
                            Name = "Vorse Raider",
                            Price = 1700,
                            AttackPoints = 1900,
                            DefensePoints = 1200,
                            Level = 4,
                            MonsterAttribute = 0,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 7,
                            Description = "This dragon has taken down countless prey with its sharp fangs. It strikes very quickly, because if it does not strike first it is vulnerable to a counter-attack.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/96005454.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/96005454.jpg",
                            Name = "Hunter Dragon",
                            Price = 1500,
                            AttackPoints = 1700,
                            DefensePoints = 100,
                            Level = 3,
                            MonsterAttribute = 0,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 8,
                            Description = "A gourmet food renowned by the Dark World upper crust. It has sensational flavor.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/97240270.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/97240270.jpg",
                            Name = "Mad Lobster",
                            Price = 1500,
                            AttackPoints = 1700,
                            DefensePoints = 1000,
                            Level = 3,
                            MonsterAttribute = 5,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 9,
                            Description = "Apparently totally unreliable, he wonders if he has incredible potential.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/60246171.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/60246171.jpg",
                            Name = "Soitsu",
                            Price = 200,
                            AttackPoints = 0,
                            DefensePoints = 0,
                            Level = 3,
                            MonsterAttribute = 6,
                            MonsterType = 0
                        },
                        new
                        {
                            Id = 10,
                            Description = "Nothing can stop the mad attack of this powerful creature.",
                            Image = "https://storage.googleapis.com/ygoprodeck.com/pics/47060154.jpg",
                            ImageSmall = "https://storage.googleapis.com/ygoprodeck.com/pics_small/47060154.jpg",
                            Name = "Mystic Clown",
                            Price = 700,
                            AttackPoints = 1500,
                            DefensePoints = 1000,
                            Level = 4,
                            MonsterAttribute = 0,
                            MonsterType = 0
                        });
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.SpellTrap", b =>
                {
                    b.HasBaseType("YugiohGanda.Core.Models.Card");

                    b.HasDiscriminator().HasValue("SpellTrap");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YugiohGanda.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Card", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Deck", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.User", "User")
                        .WithMany("Decks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.DeckCard", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.Card", "Card")
                        .WithMany("DeckCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YugiohGanda.Core.Models.Deck", "Deck")
                        .WithMany("DeckCards")
                        .HasForeignKey("DeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.Duel", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.User", "Player1")
                        .WithMany()
                        .HasForeignKey("Player1Id");

                    b.HasOne("YugiohGanda.Core.Models.User", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2Id");
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.DuelCard", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.Card", "Card")
                        .WithMany("DuelCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YugiohGanda.Core.Models.Duel", "Duel")
                        .WithMany("DuelCards")
                        .HasForeignKey("DuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohGanda.Core.Models.User", b =>
                {
                    b.HasOne("YugiohGanda.Core.Models.Deck", "CurrentDeck")
                        .WithOne()
                        .HasForeignKey("YugiohGanda.Core.Models.User", "CurrentDeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
