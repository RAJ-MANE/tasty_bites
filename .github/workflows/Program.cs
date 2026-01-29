var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable static files (wwwroot)
app.UseStaticFiles();

// Default file = index.html
app.UseDefaultFiles();

app.Run();
