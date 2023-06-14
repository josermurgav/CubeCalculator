
using Cube.Service.Interfaces;
using Cube.Service.Services;
using CubeCalculator.Classes;
using CubeCalculator.Interfaces;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//including swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//depency injection
builder.Services.AddScoped<ICubeService, clsCubeService>();
builder.Services.AddScoped<ICubeIntersectionVolume, clsCubeIntersectionVolumen>();
builder.Services.AddScoped<ICubeCollision, clsCubeCollision>();

//injecting automapper
builder.Services.AddAutoMapper(typeof(Program));
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
