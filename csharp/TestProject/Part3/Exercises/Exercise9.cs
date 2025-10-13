// // https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
// // Exercise 9: Complete a challenge activity to differentiate between do and while iteration statements

// string? ReadResult;
// Console.WriteLine("Enter a string: ");

// do
// {
//     ReadResult = Console.ReadLine();
// } while (ReadResult == null);

// /*-------------------------------------------------------------------------------------------------------------------------*/

// string? ReadResult;
// bool ValidEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");

// do
// {
//     ReadResult = Console.ReadLine();
//     if (ReadResult != null && ReadResult.Length >= 3)
//     {
//         ValidEntry = true;
//     }
//     else
//     {
//         Console.WriteLine("Invalid entry. Please enter a string containing at least three characters:");
//     }
// } while (!ValidEntry);

// /*-------------------------------------------------------------------------------------------------------------------------*/

// string? ReadResult;
// int NumericValue = 0;
// bool ValidNumber = false;

// Console.WriteLine("Enter a number:");

// do
// {
//     ReadResult = Console.ReadLine();
//     if (ReadResult != null && int.TryParse(ReadResult, out NumericValue))
//     {
//         ValidNumber = true;
//     }
//     else
//     {
//         Console.WriteLine("Invalid entry. Please enter a number:");
//     }
// } while (!ValidNumber);

// Console.WriteLine($"You entered a valid number: {NumericValue}");