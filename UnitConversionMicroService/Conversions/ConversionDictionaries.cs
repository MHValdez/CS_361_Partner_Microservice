namespace UnitConversionMicroService.Conversions;

public class ConverstionDictionaries
{

    public static readonly Dictionary<string, Dictionary<string, double>> ConverstionDictionary = new Dictionary<string, Dictionary<string, double>>
    {
        { "Length",
            new Dictionary<string, double>
            {
                { "inches",           0.0254 },
                { "feet",             0.3048 },
                { "yards",            0.9144 },
                { "miles",            1609.344 },
                { "nautical miles",   1852 },
                { "millimeters",      0.001 },
                { "centimeters",      0.01 },
                { "meters",           1 },
                { "kilometers",       1000 }
            }
        },

        { "Time",
            new Dictionary<string, double>
            {
                {"microseconds", 0.000001 },
                { "milliseconds", 0.001 },
                { "seconds",      1 },
                { "minutes",      60 },
                { "hours",        3600 },
                { "days",         86400 },
                { "weeks",        604800 }
            }
        },

        { "Mass",
            new Dictionary<string, double>
            {
                { "ounces",       0.028349523125 },
                { "pounds",       0.45359237 },
                { "short tons",   907.18474 },
                { "long tons",    1016.0469088 },
                { "milligrams",   0.000001 },
                { "grams",        0.001 },
                { "kilograms",    1 },
                { "tonnes",       1000 }
            }
        },

        { "Force",
            new Dictionary<string, double>
            {
                { "ounces",       0.0625 },
                { "pounds",       1 },
                { "Newtons",      0.2248089431 },
                { "kiloNewtons",  224.8089431 }
            }
        },

        { "Speed",
            new Dictionary<string, double>
            {
                { "feet per second",      3.28084 },
                { "miles per hour",       2.236936 },
                { "meters per second",    1 },
                { "kilometers per hour",  3.6 }
            }
        }
    };

}