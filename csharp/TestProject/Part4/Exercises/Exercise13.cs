
// Exercise - Explore data type casting and conversion
// https://learn.microsoft.com/en-gb/training/modules/csharp-convert-cast/2-exercise-data-type-conversion

/*
int first = 2;
string second = "4";
// int result = first + second;    // error CS0029: Cannot implicitly convert type 'string' to 'int'
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1)*Convert.ToInt32(value2);
Console.WriteLine(result);

int value1 = (int)1.9999m; // casting truncates
int value2 = Convert.ToInt32(1.5m); // converting rounds up
int value3 = Convert.ToInt32(1.45m);
Console.WriteLine($"value1: {value1}");
Console.WriteLine($"value2: {value2}");
Console.WriteLine($"value3: {value3}");
*/