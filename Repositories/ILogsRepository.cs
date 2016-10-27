using System.Collections.Generic;

namespace log4sky
{
    public interface ILogsRepository
    {
        IEnumerable<Log> GetAll();
    }
}