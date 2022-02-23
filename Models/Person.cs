namespace appmom3.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Borrow>? Borrow { get; set; }

    }
}
