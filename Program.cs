using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using QuestsSystem.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<QuestContext>(options =>
{
    options.UseSqlServer("Server=localhost;Initial Catalog=QuestsSystemDB;Trust Server Certificate=true; Connection Timeout=30;User ID=QuestSystem;Password=QuestSystem;");
});

// Add services to the container.
builder.Services.AddControllersWithViews();
//injecting repositories
builder.Services.AddScoped<IQuestRepository, QuestRepository>();
builder.Services.AddScoped<IMobRepository, MobRepository>();
//adding mvc?
builder.Services.AddMvc()
            .AddJsonOptions(x => x.JsonSerializerOptions.WriteIndented = true);
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
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
