using Microsoft.EntityFrameworkCore;
using WebNetMentoringProject.Helpers;
using WebNetMentoringProject.Interfaces;
using WebNetMentoringProject.Models;
using WebNetMentoringProject.Services;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting the web host");

    var builder = WebApplication.CreateBuilder(args);

    //Setup of Serilog. We can read log settings from appsettings.json (READING appsetting and ENABLES Serilogs)
    builder.Host.UseSerilog((context, services, configuration) => configuration
                        .ReadFrom.Configuration(context.Configuration)
                        .ReadFrom.Services(services)
                        .Enrich.FromLogContext());

    // Add services to the container.
    builder.Services.AddControllersWithViews();
    builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));
    builder.Services.AddScoped<IPhotoService, PhotoService>();

    builder.Services.AddDbContext<DBShopContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ShopConnectionDB"))
    );

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    //Configure HTTP request pipeline (LOGGING every request)
    app.UseSerilogRequestLogging(configure =>
    {
        configure.MessageTemplate = "HTTP {RequestMethod} {RequestPath} ({UserId}) responded {StatusCode} in {Elapsed:0.0000}ms";
    }); //log all HTTP request

    app.UseSwaggerUI();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.UseSwagger(x => x.SerializeAsV2 = true);

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.MapGet("/ping", () => "pong");
    app.MapGet("/request-context", (IDiagnosticContext diagnosticContext) =>
    {
        //can enrich the diagnostic context with custom properties in your request and filter by userid
        diagnosticContext.Set("UserId", "someone");
    });

    app.Run();
}
catch(Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}
return 0;
