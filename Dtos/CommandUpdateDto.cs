using System.ComponentModel.DataAnnotations;

namespace commandline_api.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Line { get; set; }

        [Required]
        [MaxLength(50)]
        public string Platform { get; set; }
    }
}