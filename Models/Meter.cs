namespace MeteringApplication.Meter{

    public enum MeterTypeEnum{Monofásico,
                          Bifásico,
                          Trifásico};
    public class Meter{
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public MeterTypeEnum MeterType { get; set; }
        public int Status { get; set; }
        public int Read { get; set; }
    }
}