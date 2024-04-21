using Infra;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
      opt =>
      {
          opt.Cookie.HttpOnly = true;
          opt.IdleTimeout = TimeSpan.FromMinutes(20);
          opt.Cookie.IsEssential = true;
      }
     );
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(
    opt=>opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );

builder.Services.AddScoped<IAdmin, AdminRepo>();
builder.Services.AddScoped<ICountry,CountryRepo>();
builder.Services.AddScoped<IState, StateRepo>();
builder.Services.AddScoped<ICity, CityRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.Run();
