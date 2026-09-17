namespace Ex02.Entities
{
    internal class Artist
    {
        public int Id { get; set; }
        public required string StageName { get; set; }
        public string? Bio { get; set; }
        public int LabelId { get; set; }
        public Label Label { get; set; }

        public virtual ICollection<Album>? Albums { get; set; }
    }
}
