using MeteringApplication.Models;

namespace MeteringApplication.Data
{
    public interface IUsersRepo
    {
         IEnumerable<User> GetAllUsers();

        User GetUserById(int id);
    }
}