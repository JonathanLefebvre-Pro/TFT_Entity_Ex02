using Ex02;
using Ex02.Context;
using Ex02.Entities;
using Microsoft.EntityFrameworkCore;


using (MusicLabelContext context = new MusicLabelContext())
{
    //Initialize database with values
    //DbInit.Seed(context);

    List<Artist> artists = context.Artists.Include(x => x.Label).Include(x => x.Albums).ToList();
    foreach (Artist artist in artists)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{artist.StageName} - {artist.Bio} - {artist.Label.Name}");
        Console.ForegroundColor = ConsoleColor.Yellow;

        string plur = "";
        if(artist.Albums.Count > 1) plur="s";
        Console.WriteLine($"Album{plur} :");

        foreach (Album album in artist.Albums)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"    {album.Title}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Track[] tracks = context.Tracks.Where(x => x.AlbumId == album.Id).ToArray();
            foreach (Track track in tracks)
            {
                Console.WriteLine($"    Track : {track.Title} - Duration : {track.DurationInSeconds} seconds");
            }
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
}

/*SQL Command Tools
USE EntityEx02

GO

SELECT * FROM albums
SELECT * FROM artists_albums
SELECT * FROM artists
SELECT * FROM labels
SELECT * FROM tracks

DELETE FROM tracks
DELETE FROM artists_albums
DELETE FROM albums
DELETE FROM artists
DELETE FROM labels

DBCC CHECKIDENT('tracks', RESEED, 0)
DBCC CHECKIDENT('albums', RESEED, 0)
DBCC CHECKIDENT('artists', RESEED, 0)
DBCC CHECKIDENT('labels', RESEED, 0)
*/

/*
Test request :
SELECT AL.title AS 'Album', AR.stage_name AS 'Band'
FROM dbo.albums AS AL
JOIN dbo.artists_albums AS AA ON AA.album_id = AL.album_id
JOIN dbo.artists AS AR ON AA.artist_id = AR.artist_id
ORDER BY AL.title

SELECT AR.stage_name AS 'Band', LB.name AS 'Label', AL.title AS 'Album', TR.title AS 'Track'
FROM dbo.artists AS AR
JOIN dbo.labels AS LB ON AR.label_id = LB.label_id
JOIN dbo.artists_albums AS AA ON AR.artist_id = AA.artist_id
JOIN dbo.albums AS AL ON AA.album_id = AL.album_id
JOIN dbo.tracks AS TR ON TR.album_id = AL.album_id
*/