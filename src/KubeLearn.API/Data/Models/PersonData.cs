using KubeLearn.API.Controllers.Models;
using KubeLearn.Shared;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KubeLearn.API.Data.Models;

public class PersonData : AddPerson
{
    [BsonElement("_id")]
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}