using System.Collections.Generic;
using commandline_api.Models;

namespace commandline_api.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommander();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);

    }
}