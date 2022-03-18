namespace MeteringApplication.Models{
    
    
    public class Command {
        public int Id { get; set; }
        public long Meter { get; set; }
        public string CommandSent { get; set; }
        public string Author { get; set; }
        public string Datetime { get; set; }
    }
}