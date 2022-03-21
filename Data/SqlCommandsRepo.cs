using MeteringApplication.Models;

namespace MeteringApplication.Data
{
    public class SqlCommandsRepo : ICommanderRepo
    {

        private readonly MeteringAppContext _context;

        public SqlCommandsRepo(MeteringAppContext context){
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}