using System.ComponentModel.DataAnnotations;

namespace MeteringApplication.Models{

    public enum MeterTypeEnum{Monofásico,
                          Bifásico,
                          Trifásico};
    public class Meter{
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public long SerialNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public MeterTypeEnum MeterType { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        [MaxLength(250)]
        public int Read { get; set; }
    }
}