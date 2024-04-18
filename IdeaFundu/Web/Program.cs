using Infra;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<CompanyContext>(
    opt=>opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );

builder.Services.AddScoped<IAdmin, AdminRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.Run();
