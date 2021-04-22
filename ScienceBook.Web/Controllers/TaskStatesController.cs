using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScienceBook.Web.Data;
using ScienceBook.Web.Data.Entities;
using ScienceBook.Web.ViewModels;
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
        private readonly IMapper mapper;

        public TaskStatesController(ISBRepository repository,
            ILogger<TaskStatesController> logger,
            IMapper mapper)
        {
            this.repository = repository;
            this.logger = logger;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskState>> Get()
        {
            try
            {
                var result = repository.GetTaskStates();
                return Ok(mapper.Map<IEnumerable<TaskStateViewModel>>(result));
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
                    return Ok(mapper.Map<TaskStateViewModel>(taskState));
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                logger.LogError($"Failed to get task states: {ex}");
                return BadRequest("Failed to get task states");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]TaskStateViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var taskstate = mapper.Map<TaskState>(model);

                    repository.AddEntity(taskstate);
                    repository.SaveAll();

                    return Created($"/api/taskstates/{taskstate.Id}", mapper.Map<TaskStateViewModel>(taskstate));
                }
                else
                {
                    return BadRequest(model);
                }
            }catch(Exception ex) 
            {
                logger.LogError($"Failed to save a new taskstate: {ex}");
            }

            return BadRequest("Failed to save a new taskstate");
        }
    }
}
