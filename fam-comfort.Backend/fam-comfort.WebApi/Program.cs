using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Application.Services;
using fam_comfort.Core.Models;
using fam_comfort.Persistence;
using fam_comfort.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson(x =>
{
    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
builder.Services.AddScoped<IFacadeRepository, FacadeRepository>();
builder.Services.AddScoped<IFacadeCategoryRepository, FacadeCategoryRepository>();
builder.Services.AddScoped<FacadeService>();
builder.Services.AddScoped<FacadeCategoryService>();

builder.Services.AddDbContext<FamComfortDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();