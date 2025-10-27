using e_Wallet.Application;
using e_Wallet.Mapper;
using e_Wallet.Persistence;
using e_Wallet.Persistence.Context;
using Scalar.AspNetCore;
using e_Wallet.Application.Exceptions;
var builder = WebApplication.CreateBuilder(args);

// Konfigürasyonu yapılandır
builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true);
// Servisleri ekle
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();


var app = builder.Build();

// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); 

        }
app.ConfigureExceptionHandlingMiddleware();

app.UseAuthorization();
app.MapControllers();


app.Run();
