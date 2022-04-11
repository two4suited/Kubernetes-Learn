using System.Text.Json;
using KubeLearn.API.Controllers.Models;
using KubeLearn.Shared;

namespace KubeLearn.Web.Data;

public class PersonService
{
    private readonly HttpClient _client;

    public PersonService(HttpClient client)
    {
        _client = client;
    }

    public async Task<Person[]> GetPeople()
    {
        var people = await _client.GetFromJsonAsync<Person[]>("person");
        return people;
    }
    public async Task AddPerson(AddPerson person)
    {
        await _client.PostAsJsonAsync("person",person);
        
    }

        
    
}