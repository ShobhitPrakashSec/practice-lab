/*
// Exercise - Discover Split() and Join()
// https://learn.microsoft.com/en-gb/training/modules/csharp-arrays-operations/4-exercise-split-join

string value = "abc123";
char[] valueArray = value.ToCharArray();

foreach (var character in valueArray)
{
    Console.WriteLine($"-- {character}");
}

Array.Reverse(valueArray);
//string result = new(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/