using EcommerceApi.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);


//var connectionStringProduto = builder.Configuration.GetConnectionString("ProdutoConnection");
//var connectionStringCategoria = builder.Configuration.GetConnectionString("CategoriaConnection");
var connectionStringCsm40 = builder.Configuration.GetConnectionString("Csm40Connection");

builder.Services.AddDbContext<Csm40Context>(options =>
{
    options.UseMySql(connectionStringCsm40, ServerVersion.AutoDetect(connectionStringCsm40));
});

//builder.Services.AddDbContext<ProdutoContext>(options => 
//{
//    options.UseMySql(connectionStringProduto, ServerVersion.AutoDetect(connectionStringProduto));
//});

//builder.Services.AddDbContext<CategoriaContext>(options =>
//{
//    options.UseMySql(connectionStringCategoria, ServerVersion.AutoDetect(connectionStringCategoria));
//});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
    policy.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
