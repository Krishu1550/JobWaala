using AutoMapper;
using JobPortalAPI.DataBase;
using JobPortalAPI.Repository.Interface;
using JobPortalAPI.Repository.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddAuthentication(
  JwtBearerDefaults.AuthenticationScheme   
        ).AddJwtBearer(
    p=>
    {
        var Key = Encoding.UTF8.GetBytes(builder.Configuration["JWTToken:Key"]);
        p.SaveToken = true;
        p.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JWTToken:Issuer"],
            ValidAudience = builder.Configuration["JWTToken:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Key)
        };
    }
    );

builder.Services.AddDbContext<PortelDBContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IAccountService,AccountService>();
builder.Services.AddTransient<IApplicantService,ApplicantService>();
builder.Services.AddTransient<IJobService,JobService>();   
builder.Services.AddTransient<IApplicantJobService,ApplicantJobService>();
builder.Services.AddTransient<IAdminService,AdminService>();
builder.Services.AddTransient<IHRServices,HRService>();


builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
