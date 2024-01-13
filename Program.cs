using crud_dotnet_asp.Controllers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/v1/todos", () => {
    return "Seja bem vindo";
});

app.Run();
