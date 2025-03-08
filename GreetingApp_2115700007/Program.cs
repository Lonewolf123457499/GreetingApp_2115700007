using System.Reflection;
using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using RepositaryLayer.Context;
using RepositaryLayer.Interface;
using RepositaryLayer.Service;

var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
try
{
    logger.Info("Starting the application...");

    var builder = WebApplication.CreateBuilder(args);

    // Clear default logging providers and use NLog
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var connectionString = builder.Configuration.GetConnectionString("GreetingConnection");

    builder.Services.AddDbContext<GreetingDbContext>(options => options.UseSqlServer(connectionString));



    // Add services to the container
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();


    builder.Services.AddScoped<IGreetingAppBL, GreetingAppBL>();
    builder.Services.AddScoped<IGreetingAppRL, GreetingAppRL>();



    builder.Services.AddSwaggerGen(options =>
    {
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        options.IncludeXmlComments(xmlPath);
    });

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application encountered a critical error and stopped.");
    throw;
}
finally
{
    LogManager.Shutdown(); // Ensure NLog shuts down properly
}
