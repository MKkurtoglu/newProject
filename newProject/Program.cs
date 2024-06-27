using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Contrete;
using DataAccessLayer.Contrete.EntityFramework;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);
// e�er controller sayfas�nda verileri biz constructor �zerinden �ekmek ister isek ctor'lar� yakalayamad��� i�in hata verebiliyor
//bunun i�in biz a�a��daki servisleri y�kleeyce�iz.
// Add services to the container.
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServicesDal, EfServicesDal>();
builder.Services.AddDbContext<ProjectDbContext>();
// signup sayfas� a��lmad���nda ekledik alttaki sat�r�
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ProjectDbContext>();

//builder.Services.AddControllersWithViews();
builder.Services.AddControllersWithViews().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<Program>());
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.AddMvc();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x=>
{
    x.LoginPath = "~/Login/index";
    
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Service}/{action=Index}/{id?}");

app.Run();
