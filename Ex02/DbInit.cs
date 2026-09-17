using Ex02.Context;
using Ex02.Entities;

namespace Ex02
{
    internal class DbInit
    {
        public static void Seed(MusicLabelContext context)
        {
            //if (context.Labels.Any())
                //return;

            #region Labels
            Label label_warner = new Label()
            {
                Name = "Warner Records",
                FormedDate = new DateTime(1958, 03, 19),
            };
            Label label_roadrunner = new Label()
            {
                Name = "Roadrunner Records",
                FormedDate = new DateTime(1980, 01, 01),
            };
            Label label_universal = new Label()
            {
                Name = "Universal Music Group",
                FormedDate = new DateTime(1934, 09, 01),
            };
            Label label_sony = new Label()
            {
                Name = "Sony Music",
                FormedDate = new DateTime(1929, 03, 05),
            };
            #endregion

            #region Artists
            Artist artist_linkinpark = new Artist()
            {
                StageName = "Linkin Park",
                Bio = "Groupe de nu - metal américain formé à Agoura Hills.",
                Label = label_warner
            };

            Artist artist_paparoach = new Artist()
            {
                StageName = "Papa Roach",
                Bio = "Groupe de rock alternatif américain originaire de Vacaville.",
                Label = label_warner
            };

            Artist artist_rammstein = new Artist()
            {
                StageName = "Rammstein",
                Bio = "Groupe de metal industriel allemand originaire de Berlin.",
                Label = label_universal
            };

            Artist artist_metallica = new Artist()
            {
                StageName = "Metallica",
                Bio = "Groupe de heavy metal américain originaire de Los Angeles.",
                Label = label_universal
            };

            Artist artist_systofdown = new Artist()
            {
                StageName = "System of a Down",
                Bio = "Groupe de metal alternatif américain originaire de Californie.",
                Label = label_sony
            };

            Artist artist_threedaygrace = new Artist()
            {
                StageName = "Three Days Grace",
                Bio = "Groupe de rock canadien originaire de Norwood.",
                Label = label_sony
            };

            Artist artist_slipknot = new Artist()
            {
                StageName = "Slipknot",
                Bio = "Groupe de nu - metal américain originaire de Des Moines.",
                Label = label_roadrunner
            };

            Artist artist_hollywoodundead = new Artist()
            {
                StageName = "Hollywood Undead",
                Bio = "Groupe de rap - rock américain originaire de Los Angeles.",
                Label = label_universal
            };
            #endregion

            #region Albums & Tracks
            Album album_hybtheory = new Album()
            {
                Title = "Hybrid Theory",
                ReleaseDate = new DateTime(2000, 10, 24),
                Artists = new List<Artist>([artist_linkinpark]),
                Tracks = new List<Track>([
                    new Track(){ Title="Papercut", DurationInSeconds=184 },
        new Track(){ Title="One Step Closer", DurationInSeconds=155 },
        new Track(){ Title="In the End", DurationInSeconds=216 }
                    ])
            };
            Album album_infest = new Album()
            {
                Title = "Infest",
                ReleaseDate = new DateTime(2000, 04, 25),
                Artists = new List<Artist>([artist_paparoach]),
                Tracks = new List<Track>([
                    new Track(){ Title="Infest", DurationInSeconds=249 },
        new Track(){ Title="Last Resort", DurationInSeconds=199 },
        new Track(){ Title="Broken Home", DurationInSeconds=221 }
                    ])
            };
            Album album_mutter = new Album()
            {
                Title = "Mutter",
                ReleaseDate = new DateTime(2001, 04, 02),
                Artists = new List<Artist>([artist_rammstein]),
                Tracks = new List<Track>([
                    new Track(){ Title="Mein Herz brennt", DurationInSeconds=280 },
        new Track(){ Title="Sonne", DurationInSeconds=272 },
        new Track(){ Title="Ich will", DurationInSeconds=217 }
                    ])
            };
            Album album_mastofpup = new Album()
            {
                Title = "Master of Puppets",
                ReleaseDate = new DateTime(1986, 03, 03),
                Artists = new List<Artist>([artist_metallica]),
                Tracks = new List<Track>([
                    new Track(){ Title="Battery", DurationInSeconds=312 },
        new Track(){ Title="Master of Puppets", DurationInSeconds=515 },
        new Track(){ Title="Welcome Home (Sanitarium)", DurationInSeconds=387 }
                    ])
            };
            Album album_toxicity = new Album()
            {
                Title = "Toxicity",
                ReleaseDate = new DateTime(2001, 09, 04),
                Artists = new List<Artist>([artist_systofdown]),
                Tracks = new List<Track>([
                    new Track(){ Title="Prison Song", DurationInSeconds=201 },
        new Track(){ Title="Chop Suey!", DurationInSeconds=210 },
        new Track(){ Title="Toxicity", DurationInSeconds=219 }
                    ])
            };
            Album album_onex = new Album()
            {
                Title = "One-X",
                ReleaseDate = new DateTime(2006, 06, 13),
                Artists = new List<Artist>([artist_threedaygrace]),
                Tracks = new List<Track>([
                    new Track(){ Title="It's All Over", DurationInSeconds=145 },
        new Track(){ Title="Animal I Have Become", DurationInSeconds=231 },
        new Track(){ Title="Never Too Late", DurationInSeconds=209 }
                    ])
            };
            Album album_iowa = new Album()
            {
                Title = "Iowa",
                ReleaseDate = new DateTime(2001, 08, 28),
                Artists = new List<Artist>([artist_slipknot]),
                Tracks = new List<Track>([
                    new Track(){ Title="People = Shit", DurationInSeconds=215 },
        new Track(){ Title="Disasterpiece", DurationInSeconds=308 },
        new Track(){ Title="The Heretic Anthem", DurationInSeconds=254 }
                    ])
            };
            Album album_swansongs = new Album()
            {
                Title = "Swan Songs",
                ReleaseDate = new DateTime(2008, 09, 02),
                Artists = new List<Artist>([artist_hollywoodundead]),
                Tracks = new List<Track>([
                    new Track(){ Title="Undead", DurationInSeconds=265 },
        new Track(){ Title="Everywhere I Go", DurationInSeconds=210 },
        new Track(){ Title="No. 5", DurationInSeconds=185 }
                    ])
            };
            Album album_compil_festival = new Album()
            {
                Title = "Rock & Nu-Metal Festival 2003",
                ReleaseDate = new DateTime(2003, 05, 12),
                Artists = new List<Artist>([artist_linkinpark, artist_paparoach, artist_slipknot]),
                Tracks = new List<Track>([
                    new Track(){ Title="Festival Opener", DurationInSeconds=120 },
        new Track(){ Title="All - Stars Jam Session", DurationInSeconds=340 }
                    ])
            };
            #endregion

            context.Labels.AddRange(
                label_warner, label_universal,
                label_sony, label_roadrunner);
            context.Artists.AddRange(
                artist_linkinpark, artist_paparoach,
                artist_rammstein, artist_metallica,
                artist_systofdown, artist_threedaygrace,
                artist_slipknot, artist_hollywoodundead);

            context.Albums.AddRange(
                album_hybtheory, album_infest,
                album_iowa, album_mastofpup,
                album_mutter, album_onex,
                album_swansongs, album_toxicity,
                album_compil_festival
                );

            context.SaveChanges();
        }
    }
}
