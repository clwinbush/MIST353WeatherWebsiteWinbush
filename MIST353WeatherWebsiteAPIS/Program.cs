using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using MIST353WeatherWebsiteAPIS.Data;
using MIST353WeatherWebsiteAPIS.New_Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddScoped<IChaseWinbushService, ChaseWinbushService>();
builder.Services.AddScoped<IWillBurgeService, WillBurgeService>();
builder.Services.AddScoped<IChristianMarchittoService, ChristianMarchittoService>();
builder.Services.AddScoped<IMaxsonLantzService, MaxsonLantzService>();
builder.Services.AddDbContext<DbContextClass>();
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
app.UseAuthorization();
app.MapControllers();
app.Run();
