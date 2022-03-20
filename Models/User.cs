using System.ComponentModel.DataAnnotations;

namespace MeteringApplication.Models{
    public class User{
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(250)]
        public string username { get; set; }
        [Required]
        [MaxLength(250)]
        public string email { get; set; }
        [Required]
        [MaxLength(250)]
        public string password { get; set; }
    }
}