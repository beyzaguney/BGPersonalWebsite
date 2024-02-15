using BusinessLayer.Content;
using BusinessLayer.Services;
using DataLayer;
using DataLayer.Abstract;
using DataLayer.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ctr")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAboutDal, EfAbout>();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IContactDal, EfContact>();
builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<ISkillDal, EfSkill>();
builder.Services.AddScoped<ISkillService, SkillManager>();
builder.Services.AddScoped<IPortfolioDal, EfPortfolio>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
builder.Services.AddScoped<IServiceDal, EfService>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
