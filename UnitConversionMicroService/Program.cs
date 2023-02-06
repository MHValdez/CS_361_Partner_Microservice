using UnitConversionMicroService.Models;
using UnitConversionMicroService.Conversions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/unitConversion", (Request request) =>
{
    try
    {
        var (type, quantity, magnitude, unit_from, unit_to) = request;
        var converstionDictionary = ConverstionDictionaries.ConverstionDictionary[quantity];
        var factor = converstionDictionary[unit_from] / converstionDictionary[unit_to];
        return Results.Ok(new Response(factor * magnitude, factor));
    }
    catch (Exception ex)
    {
        return Results.BadRequest(ex.Message);
    }
});

app.Run();
