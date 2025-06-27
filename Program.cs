var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// 👉 Agregar la política CORS
var corsPolicyName = "FrontendPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicyName, policy =>
    {
        policy.WithOrigins("http://localhost:62088") // Puerto actual del frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();

app.UseCors(corsPolicyName); // 👉 Activar la política CORS

app.UseAuthorization();

app.MapControllers();

app.Run();




/* 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
*/