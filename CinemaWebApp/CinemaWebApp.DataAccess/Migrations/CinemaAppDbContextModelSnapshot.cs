﻿// <auto-generated />
using System;
using CinemaWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaWebApp.DataAccess.Migrations
{
    [DbContext(typeof(CinemaAppDbContext))]
    partial class CinemaAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CinemaWebApp.DomainModels.CinemaHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SizeId");

                    b.ToTable("CinemaHall", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MovieId = 1,
                            SizeId = 6
                        },
                        new
                        {
                            Id = 2,
                            MovieId = 2,
                            SizeId = 4
                        },
                        new
                        {
                            Id = 3,
                            MovieId = 3,
                            SizeId = 6
                        },
                        new
                        {
                            Id = 4,
                            MovieId = 4,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 5,
                            MovieId = 5,
                            SizeId = 2
                        },
                        new
                        {
                            Id = 6,
                            MovieId = 6,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 7,
                            MovieId = 7,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 8,
                            MovieId = 8,
                            SizeId = 3
                        },
                        new
                        {
                            Id = 9,
                            MovieId = 5,
                            SizeId = 2
                        },
                        new
                        {
                            Id = 10,
                            MovieId = 6,
                            SizeId = 1
                        },
                        new
                        {
                            Id = 11,
                            MovieId = 4,
                            SizeId = 2
                        });
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearReleased")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movie", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "After Thanos, an intergalactic warlord, disintegrates half of the universe, the Avengers must reunite and assemble again to reinvigorate their trounced allies and restore balance.",
                            Duration = 182,
                            Genre = "Action, Adventure, Superhero, Fantasy, SCI-FI",
                            Image = "https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg",
                            Title = "Avengers: Endgame",
                            YearReleased = new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Peter Parker seeks Doctor Strange's help to make people forget about Spiderman's identity. However, when the spell he casts gets corrupted, several unwanted guests enter their universe.",
                            Duration = 148,
                            Genre = "Action, Adventure, Superhero, Fantasy, SCI-FI, Comedy",
                            Image = "https://m.media-amazon.com/images/M/MV5BZWMyYzFjYTYtNTRjYi00OGExLWE2YzgtOGRmYjAxZTU3NzBiXkEyXkFqcGdeQXVyMzQ0MzA0NTM@._V1_FMjpg_UX1000_.jpg",
                            Title = "Spider-Man: No Way Home",
                            YearReleased = new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Avengers must stop Thanos, an intergalactic warlord, from getting his hands on all the infinity stones. However, Thanos is prepared to go to any lengths to carry out his insane plan.",
                            Duration = 149,
                            Genre = "Action, Superhero, SCI-FI",
                            Image = "https://upload.wikimedia.org/wikipedia/en/4/4d/Avengers_Infinity_War_poster.jpg",
                            Title = "Avengers: Infinity War",
                            YearReleased = new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Description = "After more than 30 years of service as one of the Navy's top aviators, Pete Maverick Mitchell is where he belongs, pushing the envelope as a courageous test pilot and dodging the advancement in rank that would ground him. Training a detachment of graduates for a special assignment, Maverick must confront the ghosts of his past and his deepest fears, culminating in a mission that demands the ultimate sacrifice from those who choose to fly it.",
                            Duration = 131,
                            Genre = "Action, Drama, Adventure",
                            Image = "https://upload.wikimedia.org/wikipedia/en/thumb/1/13/Top_Gun_Maverick_Poster.jpg/220px-Top_Gun_Maverick_Poster.jpg",
                            Title = "Top Gun: Maverick",
                            YearReleased = new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Description = "n the 1970s, young Gru tries to join a group of supervillains called the Vicious 6 after they oust their leader -- the legendary fighter Wild Knuckles. When the interview turns disastrous, Gru and his Minions go on the run with the Vicious 6 hot on their tails. Luckily, he finds an unlikely source for guidance -- Wild Knuckles himself -- and soon discovers that even bad guys need a little help from their friends.",
                            Duration = 87,
                            Genre = "Adventure, Comedy",
                            Image = "https://m.media-amazon.com/images/M/MV5BZDQyODUwM2MtNzA0YS00ZjdmLTgzMjItZWRjN2YyYWE5ZTNjXkEyXkFqcGdeQXVyMTI2MzY1MjM1._V1_.jpg",
                            Title = "Minions: The Rise Of Gru",
                            YearReleased = new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Description = "Legendary space ranger Buzz Lightyear embarks on an intergalactic adventure alongside ambitious recruits Izzy, Mo, Darby, and his robot companion, Sox.As this motley crew tackles their toughest mission yet, they must learn to work together as a team to escape the evil Zurg and his dutiful robot army that are never far behind.",
                            Duration = 105,
                            Genre = "Adventure, Comedy",
                            Image = "https://m.media-amazon.com/images/M/MV5BYjhmNjczZTAtNGVhNy00ODliLTllYTctOTA5MDc5NWNlOWEwXkEyXkFqcGdeQXVyNDI3NjU1NzQ@._V1_.jpg",
                            Title = "Lightyear",
                            YearReleased = new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Description = "Doctor Strange teams up with a mysterious teenage girl from his dreams who can travel across multiverses, to battle multiple threats, including other-universe versions of himself, which threaten to wipe out millions across the multiverse.",
                            Duration = 126,
                            Genre = "Action, Adventure",
                            Image = "https://m.media-amazon.com/images/M/MV5BNWM0ZGJlMzMtZmYwMi00NzI3LTgzMzMtNjMzNjliNDRmZmFlXkEyXkFqcGdeQXVyMTM1MTE1NDMx._V1_.jpg",
                            Title = "Doctor Strange: In The Multiverse Of Madness",
                            YearReleased = new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Description = "Batman is called to intervene when the mayor of Gotham City is murdered. Soon, his investigation leads him to uncover a web of corruption, linked to his own dark past.",
                            Duration = 176,
                            Genre = "Action, Adventure",
                            Image = "https://m.media-amazon.com/images/M/MV5BMDdmMTBiNTYtMDIzNi00NGVlLWIzMDYtZTk3MTQ3NGQxZGEwXkEyXkFqcGdeQXVyMzMwOTU5MDk@._V1_.jpg",
                            Title = "The Batman",
                            YearReleased = new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.MovieProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CinemaHallId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CinemaHallId");

                    b.ToTable("MovieProgram", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaHallId = 1,
                            Date = new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(6993),
                            EndTime = "23:05",
                            Price = 250m,
                            StartTime = "20:00"
                        },
                        new
                        {
                            Id = 2,
                            CinemaHallId = 2,
                            Date = new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7025),
                            EndTime = "22:30",
                            Price = 250m,
                            StartTime = "20:00"
                        },
                        new
                        {
                            Id = 3,
                            CinemaHallId = 3,
                            Date = new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7027),
                            EndTime = "19:30",
                            Price = 250m,
                            StartTime = "17:00"
                        },
                        new
                        {
                            Id = 4,
                            CinemaHallId = 4,
                            Date = new DateTime(2022, 8, 11, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7029),
                            EndTime = "22:35",
                            Price = 250m,
                            StartTime = "20:20"
                        },
                        new
                        {
                            Id = 5,
                            CinemaHallId = 5,
                            Date = new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7031),
                            EndTime = "20:30",
                            Price = 250m,
                            StartTime = "19:00"
                        },
                        new
                        {
                            Id = 6,
                            CinemaHallId = 6,
                            Date = new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7034),
                            EndTime = "22:30",
                            Price = 250m,
                            StartTime = "20:45"
                        },
                        new
                        {
                            Id = 7,
                            CinemaHallId = 8,
                            Date = new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7037),
                            EndTime = "23:00",
                            Price = 250m,
                            StartTime = "20:00"
                        },
                        new
                        {
                            Id = 8,
                            CinemaHallId = 2,
                            Date = new DateTime(2022, 8, 12, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7039),
                            EndTime = "22:30",
                            Price = 250m,
                            StartTime = "20:00"
                        },
                        new
                        {
                            Id = 9,
                            CinemaHallId = 7,
                            Date = new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7041),
                            EndTime = "22:05",
                            Price = 250m,
                            StartTime = "20:00"
                        },
                        new
                        {
                            Id = 10,
                            CinemaHallId = 9,
                            Date = new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7043),
                            EndTime = "20:30",
                            Price = 250m,
                            StartTime = "19:00"
                        },
                        new
                        {
                            Id = 11,
                            CinemaHallId = 10,
                            Date = new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7045),
                            EndTime = "22:30",
                            Price = 250m,
                            StartTime = "20:45"
                        },
                        new
                        {
                            Id = 12,
                            CinemaHallId = 11,
                            Date = new DateTime(2022, 8, 13, 23, 29, 8, 302, DateTimeKind.Local).AddTicks(7048),
                            EndTime = "22:35",
                            Price = 250m,
                            StartTime = "20:20"
                        });
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieProgramId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SnackPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TicketQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieProgramId");

                    b.ToTable("Reservation", (string)null);
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Size", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Large Cinema Hall 1A",
                            Seats = 300
                        },
                        new
                        {
                            Id = 2,
                            Description = "Large Cinema Hall 1B",
                            Seats = 300
                        },
                        new
                        {
                            Id = 3,
                            Description = "Medium Cinema Hall 2A",
                            Seats = 200
                        },
                        new
                        {
                            Id = 4,
                            Description = "Medium Cinema Hall 2B",
                            Seats = 200
                        },
                        new
                        {
                            Id = 5,
                            Description = "Medium Cinema Hall 2C",
                            Seats = 200
                        },
                        new
                        {
                            Id = 6,
                            Description = "Small Cinema Hall 3A",
                            Seats = 100
                        },
                        new
                        {
                            Id = 7,
                            Description = "Small Cinema Hall 3B",
                            Seats = 100
                        },
                        new
                        {
                            Id = 8,
                            Description = "Small Cinema Hall 3C",
                            Seats = 100
                        });
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.Snack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Snack", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://images.unsplash.com/photo-1572177191856-3cde618dee1f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=327&q=80",
                            Name = "XL Popcorn",
                            Price = 150m
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://images.unsplash.com/photo-1589656613566-eab25964fb6b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80",
                            Name = "Nacho Crunch",
                            Price = 200m
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://images.unsplash.com/photo-1602296750425-f025b045f355?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80",
                            Name = "Sweet Taste",
                            Price = 250m
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://images.unsplash.com/photo-1589656613566-eab25964fb6b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=464&q=80",
                            Name = "XL Nacho Crunch",
                            Price = 250m
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://i.pinimg.com/736x/6b/bb/f0/6bbbf096b688ba08ad7eba24d8e083b5.jpg",
                            Name = "Slushie Mountain",
                            Price = 200m
                        });
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.SnackOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<bool>("Select")
                        .HasColumnType("bit");

                    b.Property<int>("SnackId")
                        .HasColumnType("int");

                    b.Property<int>("SnackQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("SnackId");

                    b.ToTable("SnackOrder", (string)null);
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.CinemaHall", b =>
                {
                    b.HasOne("CinemaWebApp.DomainModels.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaWebApp.DomainModels.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.MovieProgram", b =>
                {
                    b.HasOne("CinemaWebApp.DomainModels.CinemaHall", "CinemaHall")
                        .WithMany()
                        .HasForeignKey("CinemaHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.Reservation", b =>
                {
                    b.HasOne("CinemaWebApp.DomainModels.MovieProgram", "MovieProgram")
                        .WithMany()
                        .HasForeignKey("MovieProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieProgram");
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.SnackOrder", b =>
                {
                    b.HasOne("CinemaWebApp.DomainModels.Reservation", null)
                        .WithMany("SnackOrders")
                        .HasForeignKey("ReservationId");

                    b.HasOne("CinemaWebApp.DomainModels.Snack", "Snack")
                        .WithMany()
                        .HasForeignKey("SnackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("CinemaWebApp.DomainModels.Reservation", b =>
                {
                    b.Navigation("SnackOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
