namespace KubeLearn.API.Configuration;

public class MongoConfig
{
    public string ServerAddress { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Database { get; set; }
    public string Collection { get; set; }
}