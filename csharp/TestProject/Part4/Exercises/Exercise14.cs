/*
// Exercise - Examine the TryParse() method
// https://learn.microsoft.com/en-gb/training/modules/csharp-convert-cast/3-exercise-tryparse

string name = "bob";
Console.WriteLine(int.Parse(name)); // System.FormatException: The input string 'bob' was not in a correct format

// string value = "102";
string value = "bad";
if(int.TryParse(value, out int result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the Measurement");
}
*/