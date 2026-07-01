var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) => {
    Console.WriteLine("Middleware A: Authentication step.");
    if (!context.User.Identity.IsAuthenticated)
    {
        context.Response.StatusCode = 401;
        await context.Response.WriteAsync("Unauthorized");
    }
    else
    {
        await next();
    }
});

app.Use(async (context, next) => {
    Console.WriteLine("Middleware B: Logging step.");
    Console.WriteLine($"Request to: {context.Request.Path}");
    await next();
});

app.Use(async (context, next) => {
    Console.WriteLine("Middleware C: Error handling step.");
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error caught: {ex.Message}");
        context.Response.StatusCode = 500;
        await context.Response.WriteAsync("Something went wrong.");
    }
});

app.Run(async context => {
    Console.WriteLine("Middleware D: Final handler.");
    await context.Response.WriteAsync("Request completed.");
});

