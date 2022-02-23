using System.ComponentModel.DataAnnotations;

namespace appmom3.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Person")]
        public int PersonId { get; set; }
        public Person? Person { get; set; }

        [Display(Name = "CD")]
        public int CdId { get; set; }
    
        public Cd? Cd { get; set; }
    }
}
