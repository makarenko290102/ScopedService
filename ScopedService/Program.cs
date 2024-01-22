


var builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<ITimer, Timer>();
builder.Services.AddScoped<TimeService>();

var app = builder.Build();

app.UseMiddleware<TimeMiddleware>();

app.Run();