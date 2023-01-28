using UnitConversionMicroService.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/unitConversion", (Request request) =>
{
    var (type, quantity, magnitude, unit_from, unit_to) = request;
    Response response = new(1.2, 1.5);
    return Results.Ok(response);
});

app.Run();
