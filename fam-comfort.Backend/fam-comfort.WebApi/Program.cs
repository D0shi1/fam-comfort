using System.Text;
using fam_comfort.Application.Interfaces.Authentication;
using fam_comfort.Application.Interfaces.Repositories;
using fam_comfort.Application.Services;
using fam_comfort.Application.Validators;
using fam_comfort.Infrastructure;
using fam_comfort.Persistence;
using fam_comfort.Persistence.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FamComfortDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
Console.WriteLine(builder.Configuration.GetConnectionString("DefaultConnection"));

builder.Services.AddControllers().AddNewtonsoftJson(x =>
{
    x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
}).AddFluentValidation(fv =>
{
    fv.RegisterValidatorsFromAssembly(typeof(FacadeRequestValidator).Assembly);
    fv.DisableDataAnnotationsValidation = true;
});
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));
builder.Services.AddScoped<IFacadeRepository, FacadeRepository>();
builder.Services.AddScoped<IFacadeCategoryRepository, FacadeCategoryRepository>();
builder.Services.AddScoped<IDecorRepository, DecorRepository>();
builder.Services.AddScoped<IDecorCategoryRepository, DecorCategoryRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
builder.Services.AddScoped<IJwtProvider, JwtProvider>();
builder.Services.AddScoped<FacadeService>();
builder.Services.AddScoped<FacadeCategoryService>();
builder.Services.AddScoped<DecorService>();
builder.Services.AddScoped<DecorCategoryService>();
builder.Services.AddScoped<ColorService>();
builder.Services.AddScoped<UserService>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                builder.Configuration["JwtOptions:SecretKey"] ?? string.Empty))
        };

        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                context.Token = context.Request.Cookies["token"];
                
                return Task.CompletedTask;
            }
        };
    });
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    Secure = CookieSecurePolicy.Always,
    HttpOnly = HttpOnlyPolicy.Always
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();