// // https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
// // Code project 1 - write code that validates integer input

// string? userInput;
// bool isValidInput = false;
// Console.WriteLine("Enter an integer value between 5 and 10");

// while (!isValidInput)
// {
//     userInput = Console.ReadLine();
//     if(userInput != null && int.TryParse(userInput, out int userNumericValue))
//     {
//         if(userNumericValue >= 5 && userNumericValue <= 10)
//         {
//             Console.WriteLine($"your input value ({userNumericValue}) has been accepted.");
//             isValidInput = true;
//         }
//         else
//         {
//             Console.WriteLine($"You entered {userNumericValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
    
// }