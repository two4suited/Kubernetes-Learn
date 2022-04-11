using KubeLearn.API.Data.Models;

namespace KubeLearn.API.Data.Repository;

public class PersonRepository : MongoRepository<PersonData>,IPersonRepository
{
    public PersonRepository(MongoDbContext context) : base(context,"people"){}
}