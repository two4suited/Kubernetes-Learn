using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KubeLearn.Shared;
using Microsoft.AspNetCore.Mvc;

namespace KubeLearn.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public PersonController(ILogger<WeatherForecastController> logger)
        {
            this._logger = logger;
        }
        [HttpGet(Name = "Get People")]
        public IEnumerable<Person> Get()
        {
            return new List<Person>
            {
                new Person
                {
                    FirstName="Brian",
                    LastName="Sheridan"
                }
            };
        }
        [HttpPost(Name = "Add Person")]
        public IActionResult AddPerson([FromBody] Person person)
        {
            return Ok(person);
        }
    }
}