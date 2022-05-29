using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Data;

//Create a private static CreateDbIfNotExists() method under the Main() method.
static void CreateDbIfNotExists(IHost host) {
    using (var scope = host.Services.CreateScope()){
        var services = scope.ServiceProvider;
        var context = services.GetRequiredService<DataContext>();
        context.DbInitializer.Initialize(context);
    }
}   
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

CreateDbIfNotExists(app);
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
