using System.Data;
using MySql.Data.MySqlClient;
using PizzaMaze;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.App;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IDbConnection>((s) =>
{
    IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("pizza_maze"));
    conn.Open();
    return conn;
});

builder.Services.AddTransient<IMenuRepository, MenuRepository>();
var app = builder.Build();