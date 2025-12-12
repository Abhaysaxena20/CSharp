using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebApplication3;
using WebApplication3.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("newConnection"));
});

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

app.UseRouting();

app.UseAuthorization();
Console.WriteLine("--------------------");
Console.WriteLine(new StackTrace(true));
Console.WriteLine("--------------------");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Personal}/{action=Home}/{id?}");

app.Run();
