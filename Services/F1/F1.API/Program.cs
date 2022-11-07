using F1.API.Extensions;
using F1.Application;
using F1.Infrastructure;
using F1.Infrastructure.Persistence;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();
app.MigrateDatabase<F1Context>((context, services) =>
{
    var logger = services.GetRequiredService<ILogger<F1ContextSeed>>();
    var seedContext = new F1ContextSeed(services.GetRequiredService<IPublishEndpoint>());
    seedContext.SeedAsync(context,logger);
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("http://localhost:4200"));


app.UseAuthorization();

app.MapControllers();

app.Run();
