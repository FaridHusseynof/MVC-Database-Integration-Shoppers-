
//6.SQLde uygun tablemin datalarini daxil edirem;



using Microsoft.EntityFrameworkCore;
using MVC_Database_Integration__Shoppers_.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShoppersDbContext>(options =>
{
    options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Shoppers;Trusted_Connection=True;TrustServerCertificate=True;");
});
var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );
app.Run();
