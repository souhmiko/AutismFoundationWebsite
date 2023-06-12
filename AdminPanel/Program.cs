global using ShareProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectingString =
    builder.Configuration.GetConnectionString("DatabaseAutism") ??
    throw new InvalidCastException("Connection string'DatabaseAutism' not found");

builder.Services.AddDbContext<DatabaseAutismContext>(options =>
    options.UseSqlServer(connectingString));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{ 
    options.User.RequireUniqueEmail= true;
    options.Password.RequireDigit= false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<DatabaseAutismContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    //cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(365);
    options.LoginPath = "/Identity/Pages/Account/Login";
    options.AccessDeniedPath = "/Identuty/Pages/Account/AccessDenied";
    options.SlidingExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
