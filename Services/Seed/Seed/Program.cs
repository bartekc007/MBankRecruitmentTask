using EventBus.Messages.Common;
using EventBus.Messages.Events;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Seed.DatabaseContext;
using Seed.EventBusConsumer;
using Seed.Mappings;
using Seed.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICsvService, CsvService>();
builder.Services.AddDbContext<F1Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("F1ConnectionString"));
});
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddMassTransit(config =>
{
    config.AddConsumer<GenerateDataConsumer>();
    config.UsingRabbitMq((ctx, cfg) =>
    {
        cfg.Host(builder.Configuration["EventBusSettings:ConnectionString"]);
        cfg.ReceiveEndpoint(EventBusConstans.GenerateDataQuee, c =>
        {
            c.ConfigureConsumer<GenerateDataConsumer>(ctx);
        });
    });
});

var app = builder.Build();




app.Run();

