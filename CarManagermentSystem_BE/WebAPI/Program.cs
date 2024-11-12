using Application.Commons;
using CloudinaryDotNet;
using Infrastructure;
using WebAPI;
using WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration.Get<AppConfiguration>();
builder.Services.AddInfrastructuresService(configuration.DatabaseConnection);
builder.Services.AddWebAPIService();
builder.Services.AddSingleton(configuration);

builder.Services.AddSingleton(configuration);

//Cloudinary
var cloudinarySettings = builder.Configuration.GetSection("CloudinarySettings").Get<CloudinarySetting>();

var cloudinary = new Cloudinary(new Account(
    cloudinarySettings.CloudName,
    cloudinarySettings.ApiKey,
    cloudinarySettings.ApiSecret));

builder.Services.AddSingleton(cloudinary);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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
app.UseMiddleware<GlobalExceptionMiddleware>();
app.UseMiddleware<PerformanceMiddleware>();
app.MapHealthChecks("/healthchecks");

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.MapControllers();

app.Run();
public partial class Program { }