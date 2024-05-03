using Infra;
using Microsoft.EntityFrameworkCore;
using Repository;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
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
builder.Services.AddScoped<IUser,UserRepo>();
builder.Services.AddScoped<ICountry,CountryRepo>();
builder.Services.AddScoped<IState, StateRepo>();
builder.Services.AddScoped<ICity, CityRepo>();
builder.Services.AddScoped<ICategory, CategoryRepo>();
builder.Services.AddScoped<ISubCategory, SubCategoryRepo>();
builder.Services.AddScoped<IDocumentType, DocumentTypeRepo>();
builder.Services.AddScoped<IUserTC, UserTCRepo>();
builder.Services.AddScoped<IInvestorTC, InvestorTCRepo>();
builder.Services.AddScoped<IPreviousWork, PreviousWorkRepo>();
builder.Services.AddScoped<IIdea, IdeaRepo>();
builder.Services.AddScoped<IBudget, BudgetRepo>();
builder.Services.AddScoped<IRisk, RiskRepo>();
builder.Services.AddScoped<IMember,MemberRepo>();
builder.Services.AddScoped<IStages,StagesRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.Run();
