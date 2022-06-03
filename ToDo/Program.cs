using ToDo.Sevices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITodoInterface, TodoRepository>();

var app = builder.Build();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=ToDo}/{action=Index}/{id?}"
    );

app.Run();
