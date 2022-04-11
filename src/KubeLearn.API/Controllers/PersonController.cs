using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KubeLearn.API.Controllers.Models;
using KubeLearn.API.Services;
using KubeLearn.Shared;
using Microsoft.AspNetCore.Mvc;

namespace KubeLearn.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger,IPersonService personService)
        {
            this._logger = logger;
            _personService = personService;
        }
        [HttpGet(Name = "Get People")]
        public async Task<IEnumerable<Person>> Get()
        {
            return await _personService.GetPeople();
        }
        [HttpPost(Name = "Add Person")]
        public async Task<Person> AddPerson([FromBody] AddPerson person)
        {
            return await _personService.AddPerson(person);
        }
    }
}