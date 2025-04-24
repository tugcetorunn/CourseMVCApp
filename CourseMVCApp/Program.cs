using CourseMVCApp.Data;
using CourseMVCApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// dbcontext s�n�f�m�z� container a ekliyoruz ki dependency injection ile kullanabilelim.
builder.Services.AddDbContext<CourseDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseConnection")));

// Identity i�in gerekli olan s�n�flar� ekliyoruz.
builder.Services.AddDefaultIdentity<Ogretmen>()
    .AddEntityFrameworkStores<CourseDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Authentication ve Authorization middlewarelerini ekliyoruz.
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}"); // default route olarak Auth controller � ve Login action � ayarland�.

app.Run();
