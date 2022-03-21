using MeteringApplication.Models;

namespace MeteringApplication.Data
{
    public interface IMetersRepo
    {
         IEnumerable<Meter> GetAllMeters();

        Meter GetMeterBySerialNumber(long SerialNumber);
    }
}