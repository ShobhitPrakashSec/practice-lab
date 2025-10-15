// https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements
// Code project 3 - Write code that processes the contents of a string array

string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

int periodLocation;

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf('.');
    string mySentence;

    while(periodLocation != -1)
    {
        mySentence = myString[..periodLocation];
        myString = myString[(periodLocation + 1)..].TrimStart();
        periodLocation = myString.IndexOf('.');
        Console.WriteLine(mySentence);
    }

    Console.WriteLine(myString);
}
