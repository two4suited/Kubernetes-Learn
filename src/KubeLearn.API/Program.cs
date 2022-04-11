using KubeLearn.API.Configuration;
using KubeLearn.API.Data;
using KubeLearn.API.Data.Repository;
using KubeLearn.API.Services;

var builder = WebApplication.CreateBuilder(args);


//Configuration

builder.Services.Configure<Config>(builder.Configuration);

// Add services to the container.
builder.Services.AddSingleton<IPersonRepository, PersonRepository>();
builder.Services.AddSingleton<IPersonService, PersonService>();
builder.Services.AddSingleton<MongoDbContext>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
