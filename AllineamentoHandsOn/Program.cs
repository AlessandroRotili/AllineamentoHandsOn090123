using AllineamentoHandsOn._01_BusinessLayer._01_Interfaces;
using AllineamentoHandsOn._01_BusinessLayer._02_Services;
using AllineamentoHandsOn._02_DataAccessLayer.Interfaces;
using AllineamentoHandsOn._02_DataAccessLayer.Services;
using AllineamentoHandsOn._03_PresentationLayer.Context;
using AllineamentoHandsOn._03_PresentationLayer.Controllers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CompaniesAdCtx>(option => option.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=AllineamenoHandsOn"));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyDAS, CompanyDAS>();
builder.Services.AddScoped<IAdService, AdService>();
builder.Services.AddScoped<IAdDAS, AdDAS>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            //builder.WithOrigins("http://localhost:4200").AllowAnyOrigin().AllowAnyHeader();
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});
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
