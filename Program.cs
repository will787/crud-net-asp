using crud_dotnet_asp.Controllers;
using crud_dotnet_asp.ViewModels;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

TodoController c1t = new TodoController();

// app.MapGet("/v1/todos", () => $"Ola mundo em teste com uma API simples");
// //método que busca dados no servidor

app.MapPost("/v1/todos", () => "");
// método que envie dados ao servidor
app.Run();
