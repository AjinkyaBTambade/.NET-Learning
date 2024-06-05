using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCWebAppDB.Data;
using MVCWebAppDB.Repositories;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCWebAppDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCWebAppDBContext") ?? throw new InvalidOperationException("Connection string 'MVCWebAppDBContext' not found.")));

// Add services to the container.
builder.Services.AddSingleton<UserRepository>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
