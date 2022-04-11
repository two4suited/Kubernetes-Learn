using KubeLearn.API.Controllers.Models;
using KubeLearn.API.Data.Repository;
using KubeLearn.Shared;

namespace KubeLearn.API.Services;

public interface IPersonService
{
    Task<List<Person>> GetPeople();
    Task<Person> AddPerson(AddPerson person);

}