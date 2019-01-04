﻿// <auto-generated />
using System;
using Dao.DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dao.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dao.DB.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Dao.DB.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("Dao.DB.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayTeamId");

                    b.Property<int>("HomeTeamId");

                    b.Property<DateTime>("MatchDate");

                    b.Property<int>("SeasonId");

                    b.Property<int>("StadiumId");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("StadiumId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Dao.DB.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Facebook");

                    b.Property<string>("FirstName");

                    b.Property<string>("Height");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Instagram");

                    b.Property<string>("LastName");

                    b.Property<string>("Nationality");

                    b.Property<string>("Twitter");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Dao.DB.Models.PlayerMatchStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Accuracy");

                    b.Property<int>("AccurateLongBalls");

                    b.Property<int>("AerialBattlesLost");

                    b.Property<int>("AerialBattlesWon");

                    b.Property<int>("Assists");

                    b.Property<int>("BigChancesCreated");

                    b.Property<int>("BigChancesMissed");

                    b.Property<int>("BlockedShots");

                    b.Property<int>("Clearances");

                    b.Property<int>("Crosses");

                    b.Property<int>("DuelsLost");

                    b.Property<int>("DuelsWon");

                    b.Property<int>("ErrorsLeadingToGoal");

                    b.Property<int>("Fauls");

                    b.Property<int>("FreekicksScored");

                    b.Property<int>("Goals");

                    b.Property<int>("GoalsWithLeftFoot");

                    b.Property<int>("GoalsWithRightFoot");

                    b.Property<int>("HeadedClearance");

                    b.Property<int>("HeadedGoals");

                    b.Property<int>("HitWoodwork");

                    b.Property<int>("Interceptions");

                    b.Property<int>("MatchId");

                    b.Property<int>("Offsides");

                    b.Property<decimal>("PassAccuracy");

                    b.Property<int>("Passes");

                    b.Property<int>("PenaltiesScored");

                    b.Property<int>("PlayerId");

                    b.Property<int>("Recoveries");

                    b.Property<int>("RedCards");

                    b.Property<int>("SeasonTeamId");

                    b.Property<int>("Shots");

                    b.Property<int>("ShotsOnTarget");

                    b.Property<decimal>("Successful");

                    b.Property<int>("Tackles");

                    b.Property<decimal>("TacklesSuccess");

                    b.Property<int>("ThroughBalls");

                    b.Property<int>("YellowCards");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SeasonTeamId");

                    b.ToTable("PlayersMatchStats");
                });

            modelBuilder.Entity("Dao.DB.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Year");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Dao.DB.Models.SeasonTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LeagueId");

                    b.Property<int>("SeasonId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TeamId");

                    b.ToTable("SeasonTeams");
                });

            modelBuilder.Entity("Dao.DB.Models.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("Dao.DB.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Key");

                    b.Property<string>("Name");

                    b.Property<int>("Since");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Dao.DB.Models.TeamMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CleanSheets");

                    b.Property<int>("Goals");

                    b.Property<int>("MatchId");

                    b.Property<int>("MatchStatus");

                    b.Property<int>("PenaltiesScored");

                    b.Property<int>("PenaltiesWon");

                    b.Property<int>("RedCards");

                    b.Property<int>("TeamId");

                    b.Property<int>("YellowCards");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamMatches");
                });

            modelBuilder.Entity("Dao.DB.Models.TeamPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PlayerId");

                    b.Property<int>("SeasonId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("SeasonId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamPlayers");
                });

            modelBuilder.Entity("Dao.DB.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dao.DB.Models.Match", b =>
                {
                    b.HasOne("Dao.DB.Models.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Stadium", "Stadium")
                        .WithMany()
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dao.DB.Models.PlayerMatchStats", b =>
                {
                    b.HasOne("Dao.DB.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.SeasonTeam", "SeasonTeam")
                        .WithMany()
                        .HasForeignKey("SeasonTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dao.DB.Models.SeasonTeam", b =>
                {
                    b.HasOne("Dao.DB.Models.Season", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dao.DB.Models.Stadium", b =>
                {
                    b.HasOne("Dao.DB.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dao.DB.Models.TeamMatch", b =>
                {
                    b.HasOne("Dao.DB.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Dao.DB.Models.TeamPlayer", b =>
                {
                    b.HasOne("Dao.DB.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Dao.DB.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
