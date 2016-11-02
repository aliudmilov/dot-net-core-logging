using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace log4sky
{
    [Route("api/[controller]")]
    public class LogsController : Controller
    {
        public LogsController(ILogsRepository logsRepository)
        {
            LogsRepository = logsRepository;
        }
        
        
        public ILogsRepository LogsRepository
        {
            get;
            set;
        }


        // GET api/logs
        [HttpGet]
        public IEnumerable<Log> Get()
        {
            return LogsRepository.GetAll();
        }

        // GET api/logs/5
        [HttpGet("{id}")]
        public Log Get(int id)
        {
            return null;
        }

        // POST api/logs
        [HttpPost]
        public void Post([FromBody]Log value)
        {
        }

        // PUT api/logs/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Log value)
        {
        }

        // DELETE api/logs/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
