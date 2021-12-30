using DotNetCoreWebApiRepositoryPattern.Data;
using DotNetCoreWebApiRepositoryPattern.Data.EFCore;
using DotNetCoreWebApiRepositoryPattern.Models.EFCore;
using DotNetCoreWebApiRepositoryPattern.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyDBContext>(options =>
    options.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=MyDB;Trusted_Connection=True;MultipleActiveResultSets=true"));

// Add services to the container.
builder.Services.AddScoped<EfCoreMovieRepository>();
builder.Services.AddScoped<EfCoreStarRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IStarService, StarService>();

// Add AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
