namespace Ex02.Entities
{
    internal class Album
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Track> Tracks { get; set; } 

        public Album() 
        {
            Artists = new HashSet<Artist>();
            Tracks = new HashSet<Track>();
        }
    }
}
