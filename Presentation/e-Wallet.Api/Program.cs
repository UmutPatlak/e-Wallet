using e_Wallet.Application;
using e_Wallet.Application.Exceptions;
using e_Wallet.Infrastructure;
using e_Wallet.Mapper;
using e_Wallet.Persistence;
using e_Wallet.Persistence.Context;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;
using System.ComponentModel;
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
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddApplication();
builder.Services.AddCustomMapper();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
     
        Title= "UmutPatlakeWalletApi",
        Version="v1",
        Description = "e-Wallet new Api",
        });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() { 
    Name= "Authorization",
    Type= SecuritySchemeType.ApiKey,
    Scheme= "Bearer",
        BearerFormat= "JWT",
        In= ParameterLocation.Header,   
        Description="Bearer yazip bosluk biraktiktan sora tokeni girebilirsiz\r\n\r\n Ornegin Berarer erwrwerrwetsdfs "

    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
    {
        new OpenApiSecurityScheme {
            Reference = new OpenApiReference {
                Type= ReferenceType.SecurityScheme,
                Id= "Bearer"
            }
        },
Array.Empty<string>()
    }
    }); 
});

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
