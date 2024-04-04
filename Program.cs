using FURNITURE.CartServices;
using FURNITURE.Data;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LoginRegisterDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("con2")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDbContext<FurnitureDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=LoginRegisterCTR}/{action=Register}/{id?}");

app.Run();
