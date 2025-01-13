using WeatherAPI.Models;
using WeatherAPI.Services;
using WeatherAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<WeatherApiOptions>(
    builder.Configuration.GetSection("WeatherApiOptions"));
builder.Services.AddHttpClient<IExternalApiService, ExternalApiService>();
builder.Services.AddScoped<IHttpHelper, HttpHelper>();
// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers(); 

app.Run();

