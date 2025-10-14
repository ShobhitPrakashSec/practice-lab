// https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
// Code project 2 - write code that validates string input

string? userInput;
bool isValidInput = false;
string roleName;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput = Console.ReadLine();

    if(userInput != null)
    {
        roleName = userInput.Trim().ToLower();
        if (roleName == "administrator" || roleName == "manager" || roleName == "user")
        {
            Console.WriteLine($"Your input value {roleName} has been accepted.");
            isValidInput = true;
        }
        else
            Console.WriteLine($"The role name that you entered, ({roleName}) is not valid. Enter your role name (Administrator, Manager, or User)");
    }


} while (!isValidInput);