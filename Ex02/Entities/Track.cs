namespace Ex02.Entities
{
    internal class Track
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public float DurationInSeconds { get; set; }
        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
