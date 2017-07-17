﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CardGames.BeggarMyNeighbour.Scoreboard.API;
using System;

namespace CardGames.BeggarMyNeighbour.Scoreboard.API.Migrations
{
    [DbContext(typeof(ScoreBoardContext))]
    [Migration("20170528193254_addPlayers")]
    partial class addPlayers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-preview1-24937");

            modelBuilder.Entity("Scoreboard.API.Score", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Deck");

                    b.Property<int>("Lenght");

                    b.Property<DateTime>("Submitted");

                    b.Property<string>("User");

                    b.Property<DateTime?>("Verified");

                    b.Property<int>("players");

                    b.HasKey("id");

                    b.ToTable("Scores");
                });
        }
    }
}