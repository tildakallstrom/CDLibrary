using System.ComponentModel.DataAnnotations;

namespace appmom3.Models
{
    
    public class Cd
    {
        //properties
        public int Id { get; set; }
        public string? Name { get; set; }
        [Display(Name = "Releasedate")]
        public DateTime Date { get; set; }

        [Display(Name = "Artist")]
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        public Borrow? Borrow { get; set; }

        public Cd()
        {

        }
    }
}
