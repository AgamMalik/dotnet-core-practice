var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.Run(async (HttpContext context) => 
{
    await context.Response.WriteAsync("Welcome from Asp.net");
});

app.Run();