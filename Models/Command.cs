using System.ComponentModel.DataAnnotations;

namespace commandline_api.Models
{
    public class Command
    {
        [Key]
        [Required]
        
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}