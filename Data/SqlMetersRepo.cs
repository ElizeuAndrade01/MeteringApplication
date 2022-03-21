using MeteringApplication.Models;

namespace MeteringApplication.Data
{
    public class SqlMetersRepo : IMetersRepo
    {
        private readonly MeteringAppContext _context;

        public SqlMetersRepo(MeteringAppContext context){
            _context = context;
        }

        public IEnumerable<Meter> GetAllMeters()
        {
            return _context.Meters.ToList();
        }

        public Meter GetMeterBySerialNumber(long SerialNumber)
        {
            return _context.Meters.FirstOrDefault(p => p.SerialNumber == SerialNumber);
        }
    }
}