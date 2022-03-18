using MeteringApplication.Models;

namespace MeteringApplication.Data{
    public class MockCommandsRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command{Id=1, Meter = 421515, CommandSent = "Refresh data",
                            Author = "Elizeu Andrade", Datetime="18/03/2022"},
                new Command{Id=2, Meter = 458181, CommandSent = "Change Status",
                            Author = "José Cavalcante", Datetime="15/03/2022"},
                new Command{Id=3, Meter = 121315, CommandSent = "Refresh data",
                            Author = "Francisco Martins", Datetime="12/03/2022"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=1, Meter = 421515, CommandSent = "Refresh data",
                            Author = "Elizeu Andrade", Datetime="18/03/2022"};
        }
    }
}