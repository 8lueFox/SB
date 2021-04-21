using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScienceBook.Web.Data;
using ScienceBook.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskStatesController : ControllerBase
    {
        private readonly ISBRepository repository;
        private readonly ILogger<TaskStatesController> logger;

        public TaskStatesController(ISBRepository repository, ILogger<TaskStatesController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskState>> Get()
        {
            try
            {
                return Ok(repository.GetTaskStates());
            }
            catch(Exception ex)
            {
                logger.LogError($"Failed to get task states: {ex}");
                return BadRequest("Failed to get task states"); 
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<TaskState> Get(int id)
        {
            try
            {
                var taskState = repository.GetTaskState(id);

                if (taskState != null)
                    return Ok(taskState);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get task states: {ex}");
                return BadRequest("Failed to get task states");
            }
        }
    }
}
