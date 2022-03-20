using System.ComponentModel.DataAnnotations;

namespace MeteringApplication.Models{
    
    
    public class Command {
        [Key]
        public int Id { get; set; }
        [Required]
        public long Meter { get; set; }
        [Required]
        [MaxLength(250)]
        public string CommandSent { get; set; }
        [Required]
        [MaxLength(250)]
        public string Author { get; set; }
        [Required]
        [MaxLength(250)]
        public string Datetime { get; set; }
    }
}