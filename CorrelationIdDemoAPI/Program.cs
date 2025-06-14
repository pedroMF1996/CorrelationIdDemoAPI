using CorrelationIdDemoAPI.Application.Service;
using CorrelationIdDemoAPI.Domain.Interfaces.Repositories;
using CorrelationIdDemoAPI.Domain.Interfaces.Services;
using CorrelationIdDemoAPI.Infrastructure.DAL.Repositories;
using CorrelationIdDemoAPI.Infrastructure.Log.Middlewares;
using CorrelationIdDemoAPI.Infrastructure.Log.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configuração de serviços
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICorrelationIdService, CorrelationIdService>();
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddScoped<CorrelationIdDemoAPILogMiddleware>();

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

app.UseMiddleware<CorrelationIdDemoAPILogMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
