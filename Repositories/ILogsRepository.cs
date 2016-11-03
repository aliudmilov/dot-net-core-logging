using System.Collections.Generic;

namespace log4sky
{
    public interface ILogsRepository
    {

        void Add(Log item);

        Log Get(int id);

        IEnumerable<Log> GetAll();

        void DeleteAll();
    }
}