﻿using RealEstate.API.Models;
using RealEstate.API.Repositories.BottomGridRepositories;
using RealEstate.API.Repositories.CategoryRepositories;
using RealEstate.API.Repositories.EmployeeRepositories;
using RealEstate.API.Repositories.PopularLocationRepositories;
using RealEstate.API.Repositories.ProductRepositories;
using RealEstate.API.Repositories.ServiceRepositories;
using RealEstate.API.Repositories.TestimonialRepositories;
using RealEstate.API.Repositories.WhoWeAreRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<Context>();

builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IWhoWeAreDetailRepository , WhoWeAreDetailRepository>();
builder.Services.AddTransient<IServiceRepository , ServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository , BottomGridRepository>();
builder.Services.AddTransient<ITestimonailRepository , TestimonailRepository>();
builder.Services.AddTransient<IPopularLocationRepository , PopularLocationRepository>();
builder.Services.AddTransient<IEmployeeRepository , EmployeeRepository>();


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
