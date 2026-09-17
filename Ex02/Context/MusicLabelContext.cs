using Azure;
using Ex02.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ex02.Context
{
    internal class MusicLabelContext : DbContext
    {
        public DbSet<Label> Labels { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JONATHAN\DATAVIZ;" +
                              "Database=EntityEx02;" +
                              "Trusted_Connection=True;" +
                              "TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Label>().ToTable("labels");
            modelBuilder.Entity<Label>().HasIndex(x => x.Name).IsUnique();
            modelBuilder.Entity<Label>().HasKey(x => x.Id);
            modelBuilder.Entity<Label>().Property(x => x.Id).UseIdentityColumn();
            modelBuilder.Entity<Label>().Property(x => x.Id).HasColumnName("label_id");
            modelBuilder.Entity<Label>().Property(x => x.Name).HasColumnName("name")
                .HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Label>().Property(x => x.FormedDate).HasColumnName("formed_date");

            //Relations
            modelBuilder.Entity<Label>().HasMany(x => x.Artists).WithOne(x => x.Label)
                .HasForeignKey(x => x.LabelId).OnDelete(DeleteBehavior.Restrict);
            //

            modelBuilder.Entity<Album>().ToTable("albums");
            modelBuilder.Entity<Album>().HasIndex(x => x.Title).IsUnique();
            modelBuilder.Entity<Album>().HasKey(x => x.Id);
            modelBuilder.Entity<Album>().Property(x => x.Id).UseIdentityColumn();
            modelBuilder.Entity<Album>().Property(x => x.Id).HasColumnName("album_id");
            modelBuilder.Entity<Album>().Property(x => x.Title).HasColumnName("title")
                .HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Album>().Property(x => x.ReleaseDate).HasColumnName("release_date");

            //Relations
            modelBuilder.Entity<Album>().HasMany(x => x.Tracks);
            //

            modelBuilder.Entity<Artist>().ToTable("artists");
            modelBuilder.Entity<Artist>().HasIndex(x => x.StageName).IsUnique();
            modelBuilder.Entity<Artist>().HasKey(x => x.Id);
            modelBuilder.Entity<Artist>().Property(x => x.Id).UseIdentityColumn();
            modelBuilder.Entity<Artist>().Property(x => x.Id).HasColumnName("artist_id");
            modelBuilder.Entity<Artist>().Property(x => x.StageName).HasColumnName("stage_name")
                .HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Artist>().Property(x => x.LabelId).HasColumnName("label_id");
            //modelBuilder.Entity<Artist>().HasOne(x => x.Label).WithMany(x => x.Artists).HasForeignKey("label_id");

            //Relations
            //modelBuilder.Entity<Artist>().HasOne(x => x.Label);
            modelBuilder.Entity<Artist>().HasMany(x => x.Albums).WithMany(x => x.Artists)
                .UsingEntity("artists_albums",
                //r => r.HasOne(typeof(Album)).WithMany().HasForeignKey("AlbumsId"),
                //l => l.HasOne(typeof(Artist)).WithMany().HasForeignKey("ArtistsId"),
                j => 
                { 
                    j.Property("AlbumsId").HasColumnName("album_id");
                    j.Property("ArtistsId").HasColumnName("artist_id");
                    //j.HasKey("album_id", "artist_id")
                }
               );
            //

            modelBuilder.Entity<Track>().ToTable("tracks");
            modelBuilder.Entity<Track>().HasKey(x => x.Id);
            modelBuilder.Entity<Track>().Property(x => x.Id).UseIdentityColumn();
            modelBuilder.Entity<Track>().Property(x => x.Id).HasColumnName("track_id");
            modelBuilder.Entity<Track>().Property(x => x.Title).HasColumnName("title")
                .HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Track>().Property(x => x.DurationInSeconds).HasColumnName("duration_in_seconds");
            modelBuilder.Entity<Track>().Property(x => x.AlbumId).HasColumnName("album_id");

            //Relations
            modelBuilder.Entity<Track>().HasOne(x => x.Album);
            //
        }
    }
}
