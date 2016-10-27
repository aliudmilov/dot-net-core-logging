using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace log4sky
{
    public class LogsRepository : ILogsRepository
    {
        private ConcurrentDictionary<string, Log> _logs;

        public LogsRepository()
        {
            _logs = new ConcurrentDictionary<string, Log>();
            _logs.TryAdd(
                "1", 
                new Log()
                {
                    Id = 1,
                    DateWritten = DateTime.UtcNow,
                    Territory = "testTerritory",
                    Proposition = "testProposition",
                    PropositionVersion = "testVersion",
                    Platform = "testPlatform",
                    PlatformOs = "testPlatformOs",
                    PlatformOsVersion = "testPlatformOsVersion",
                    Runtime = Guid.NewGuid().ToString(),
                });
        }

        public IEnumerable<Log> GetAll()
        {
            return _logs.Values;
        }
    }
}