using KubeLearn.API.Controllers.Models;
using KubeLearn.API.Data.Models;
using KubeLearn.API.Data.Repository;
using KubeLearn.API.Extensions;
using KubeLearn.Shared;

namespace KubeLearn.API.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
    public async Task<List<Person>> GetPeople()
    {
        var data = await _personRepository.GetAll();
        return data.ToPersonList();
    }

    public async Task<Person> AddPerson(AddPerson person)
    {
        var personData = new PersonData()
        {
            FirstName = person.FirstName,
            LastName = person.LastName
        };

        var enteredData = await _personRepository.Add(personData);
        return enteredData.To();
    }
}