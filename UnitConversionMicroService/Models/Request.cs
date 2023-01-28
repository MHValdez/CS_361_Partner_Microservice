namespace UnitConversionMicroService.Models;

public record Request(string Type, string Quantity, double Magnitude, string Unit_from, string Unit_to);
