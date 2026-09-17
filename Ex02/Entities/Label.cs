namespace Ex02.Entities
{
    internal class Label
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime FormedDate { get; set; }

        public virtual ICollection<Artist> Artists { get; set; }
    }
}
