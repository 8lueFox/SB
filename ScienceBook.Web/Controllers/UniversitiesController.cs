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
    [Produces("application/json")]
    public class UniversitiesController : ControllerBase
    {
        private readonly ISBRepository repository;
        private readonly ILogger<UniversitiesController> logger;

        public UniversitiesController(ISBRepository repository, ILogger<UniversitiesController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<IEnumerable<University>> Get()
        {
            try
            {
                return Ok(repository.GetUniversitiesWithDepartments());
            }
            catch(Exception ex)
            {
                logger.LogError($"Failed to get universities: {ex}");
                return BadRequest("Failed to get universities");
            }
        }
    }
}
