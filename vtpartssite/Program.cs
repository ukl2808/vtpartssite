using vtpartssite.Interfaces;
using vtpartssite.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<INewService, vtpartssite.Service.NewService>(); // Регистрация сервиса
builder.Services.AddScoped<IHelloRepository, HelloRepository>(); // Регистрация сервиса

// Swagger/OpenAPI для документации API
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

