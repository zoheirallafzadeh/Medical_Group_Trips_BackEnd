using App.Infa.Data.Db.SqlServer.Ef.DbCtx;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(@"Server=DESKTOP-OG56BKU;Integrated Security=true;Database=GPRI13;TrustServerCertificate=True;").LogTo(Console.WriteLine));


builder.Services.AddIdentity<User, Role>(option =>
{
    option.Password.RequireUppercase = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequiredLength = 6;
    option.Password.RequiredUniqueChars = 2;
}
).AddEntityFrameworkStores<AppDbContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();




app.MapControllerRoute(
      name: "areas",
      pattern: "api/{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllers();

app.Run();
