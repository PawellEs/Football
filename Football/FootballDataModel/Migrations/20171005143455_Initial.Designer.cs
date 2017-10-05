﻿// <auto-generated />
using FootballDataModel.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FootballDataModel.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20171005143455_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootballDataModel.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LeagueId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("FootballDataModel.Models.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("FootballDataModel.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("GuestTeamGoals");

                    b.Property<int>("GuestTeamId");

                    b.Property<int>("HomeTeamGoals");

                    b.Property<int>("HomeTeamId");

                    b.HasKey("Id");

                    b.HasIndex("GuestTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("FootballDataModel.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("FootballDataModel.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootballDataModel.Models.PlayerClub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubId");

                    b.Property<DateTime>("JoinDate");

                    b.Property<DateTime?>("LeaveDate");

                    b.Property<int>("PlayerId");

                    b.Property<float>("TransferValue");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayersClubs");
                });

            modelBuilder.Entity("FootballDataModel.Models.PlayerGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GameId");

                    b.Property<TimeSpan>("PlayerEntryTime");

                    b.Property<int>("PlayerId");

                    b.Property<TimeSpan>("PlayerLeaveTime");

                    b.Property<string>("PlayerPosition");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayersGames");
                });

            modelBuilder.Entity("FootballDataModel.Models.Club", b =>
                {
                    b.HasOne("FootballDataModel.Models.League", "League")
                        .WithMany("Clubs")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FootballDataModel.Models.Game", b =>
                {
                    b.HasOne("FootballDataModel.Models.Club", "GuestTeam")
                        .WithMany("GuestGames")
                        .HasForeignKey("GuestTeamId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballDataModel.Models.Club", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FootballDataModel.Models.PlayerClub", b =>
                {
                    b.HasOne("FootballDataModel.Models.Club", "Club")
                        .WithMany("PlayersClub")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballDataModel.Models.Player", "Player")
                        .WithMany("PlayerClubs")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FootballDataModel.Models.PlayerGame", b =>
                {
                    b.HasOne("FootballDataModel.Models.Game", "Game")
                        .WithMany("PlayersInGame")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FootballDataModel.Models.Player", "Player")
                        .WithMany("PlayerGames")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
