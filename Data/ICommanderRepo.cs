using MeteringApplication.Models;

namespace MeteringApplication.Data
{
    public interface ICommanderRepo{
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);
    }
}