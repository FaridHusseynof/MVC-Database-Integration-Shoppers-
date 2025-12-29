//1.One to Many relationumu qururam
//2.One teref Many terefi ICollection<manyteref>
//3.Many teref ise one terefi hem idsin tutur, hem de obyektin ozu
//4.DB d ayeni yaratdigim modelleri tanitdim ve migration yaratdim
//5.tableli doldurdum ve HomeViewModelde bildirdim
//6.HVMde bildirdikden sonra shetleri verib isDeleted deyeri false
//olanlari ve include ile lazimi datalari da ozumuzle goturdukden sonra
//cshtmlde foreache salib getitirik
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
