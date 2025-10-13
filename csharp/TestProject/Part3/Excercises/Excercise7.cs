// // Exercise 7 - Create do and while iteration loops
// // https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/2-exercise-do-while-continue

// Random random = new();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// Write a while statement that iterates only while a random number is greater than some value

// Random random = new();
// int current = random.Next(1, 11);

// while (current > 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// // Use the continue statement to step directly to the Boolean expression

// Random random = new();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     if (current > 8)
//         continue;
//     Console.WriteLine(current);
// }while (current != 7);