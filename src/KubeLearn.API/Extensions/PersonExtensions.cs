using KubeLearn.API.Data.Models;
using KubeLearn.Shared;

namespace KubeLearn.API.Extensions;

public static class PersonExtensions
{
    public static Person To(this PersonData personData)
    {
        if (personData == null) return null;

        return new Person()
        {
            Id = personData.Id,
            FirstName = personData.FirstName,
            LastName = personData.LastName
        };
    }

    public static List<Person> ToPersonList(this IQueryable<PersonData> personData)
    {
        var personList = new List<Person>();
        foreach (var person in personData)
        {
            personList.Add(person.To());
        }

        return personList;
    }
    
    public static PersonData From(this Person person)
    {
        if (person == null) return null;

        return new PersonData()
        {
            Id = person.Id,
            FirstName = person.FirstName,
            LastName = person.LastName
        };
    }
}