/*
// Exercise - Discover reference types
// https://learn.microsoft.com/en-gb/training/modules/csharp-choose-data-type/5-exercise-reference-types

int[] data;
data = new int[3];
// int[] data = new int[3]; //shorten version

string shortHandString = "Hello World!";
Console.WriteLine(shortHandString);


// VALUE TYPE
int val_a = 2;
int val_b = val_a;
val_b = 5;

Console.WriteLine("--Values Types--");
Console.WriteLine($"val_a: {val_a}");
Console.WriteLine($"val_b: {val_b}");

// REFRENCE TYPE
int[] ref_a = new int[1];
ref_a[0] = 2;
int[] ref_b = ref_a;
ref_b[0] = 5;

Console.WriteLine("--refrence types--");
Console.WriteLine($"ref_a: {ref_a[0]}");
Console.WriteLine($"ref_b: {ref_b[0]}");
*/