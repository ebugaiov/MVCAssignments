using MVCAssignment4.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

// -------------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseStaticFiles();
app.UseSession();

// --------------------------------------

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();