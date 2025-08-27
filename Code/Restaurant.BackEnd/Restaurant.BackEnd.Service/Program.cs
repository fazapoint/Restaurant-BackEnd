using Microsoft.EntityFrameworkCore;
using Restaurant.BackEnd.Service;

var builder = WebApplication.CreateBuilder(args);

// Get connection string from appsetting.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


// Register AppDbContext with Dependency Injection (DI)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Configure JSON serialization to handle reference loops

// Add services to the container

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            policy.WithOrigins(
                "http://localhost:3000",
                "xxx.com") // React app URL
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Security middlewares
app.UseHttpsRedirection(); // Force HTTP requests to redirect to HTTPS
app.UseHsts(); // HTTP Strict Transport Security (HSTS)

app.UseCors("AllowReactApp"); // Enable CORS here

Console.WriteLine("I am Faza");
// line after app.Run() will never be executed
app.Run();

