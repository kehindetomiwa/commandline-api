using System.Collections.Generic;
using commandline_api.Models;

namespace commandline_api.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommander();
        Command GetCommandById(int id);
    }
}