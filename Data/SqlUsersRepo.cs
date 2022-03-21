using MeteringApplication.Models;

namespace MeteringApplication.Data
{
    public class SqlUsersRepo : IUsersRepo
    {
        private readonly MeteringAppContext _context;

        public SqlUsersRepo(MeteringAppContext context){
            _context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.id == id);
        }
    }
}