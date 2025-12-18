/*
// Exercise - Complete a challenge to combine string array values as strings and as integers
// https://learn.microsoft.com/en-gb/training/modules/csharp-convert-cast/4-challenge

using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = ["12.36", "45", "ABC", "11", "DEF"];
decimal total = 0.0m;
string message = "";

foreach (var value in values)
{
    if(decimal.TryParse(value, out decimal value1))
    {
        total += value1;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/