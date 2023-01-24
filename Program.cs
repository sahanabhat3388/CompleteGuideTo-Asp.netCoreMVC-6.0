using Asp.netCoreMVCIntro.Context;
using Asp.netCoreMVCIntro.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Register DbContext
var connectionString = builder.Configuration.GetConnectionString("TutorialDbConnection");
builder.Services.AddDbContext<TutorialDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
           Path.Combine(Directory.GetCurrentDirectory(), "StaticFileTesting")),
    RequestPath = "/StaticFileTesting"
});

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "addtutorial",
    pattern: "/newtutorial",
    defaults: new { controller = "Tutorial", action = "CreateTutorial" });


app.Run();
