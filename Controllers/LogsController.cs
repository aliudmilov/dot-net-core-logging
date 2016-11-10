using System;
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
            private set;
        }


        // GET api/logs
        [HttpGet]
        public IEnumerable<Log> Get()
        {
            return LogsRepository.GetAll();
        }

        // GET api/logs/5
        [HttpGet("{id}", Name = "GetLog")]
        public IActionResult Get(int id)
        {
            Log item = LogsRepository.Get(id);

            if (item == null) return NotFound();

            return new OkObjectResult(item);
        }

        // POST api/logs
        [HttpPost]
        public IActionResult Post([FromBody]Log value)
        {
            if (value == null) return BadRequest();

            try
            {
                value.DateWritten = DateTime.UtcNow;
                LogsRepository.Add(value);
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return CreatedAtRoute("GetLog", new { @id = value.Id }, value);
        }

        // DELETE api/logs
        [HttpDelete]
        public IActionResult DeleteAll()
        {
            LogsRepository.DeleteAll();

            return new NoContentResult();
        }
    }
}
