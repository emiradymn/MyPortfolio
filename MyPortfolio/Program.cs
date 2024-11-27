using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// builder.Services.AddDbContext<MyPortfolioContext>(options =>
// {
//     var connectionString = builder.Configuration.GetConnectionString("mysql_connection");
//     var serverVersion = new MySqlServerVersion(new Version(8, 0, 39)); // MySQL sürüm numarasını uygun şekilde ayarlayın
//     options.UseMySql(connectionString, serverVersion);
// });


var mysqlPassword = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");

var connectionString = builder.Configuration.GetConnectionString("mysql_connection") +
                       $"Password={mysqlPassword};";


builder.Services.AddDbContext<MyPortfolioContext>(options =>
{
    var serverVersion = new MySqlServerVersion(new Version(8, 0, 39)); // MySQL sürüm numarasını uygun şekilde ayarlayın
    options.UseMySql(connectionString, serverVersion);
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
