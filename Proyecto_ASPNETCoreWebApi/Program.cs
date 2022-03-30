using Microsoft.EntityFrameworkCore;
using DepartmentApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DepartmentContext>(opt => new DepartmentContext());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();    
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();