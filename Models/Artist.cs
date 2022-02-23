namespace appmom3.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Genre { get; set; }
        public List<Cd>? Cds { get; set; }
    }
}
