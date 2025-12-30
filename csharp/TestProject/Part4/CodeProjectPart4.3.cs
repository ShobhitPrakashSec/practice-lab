/*
// Exercise - Complete a challenge to reverse words in a sentence
// https://learn.microsoft.com/en-gb/training/modules/csharp-arrays-operations/5-challenge-1
*/

string pangram = "The quick brown fox jumps over the lazy dog";
string[] wordArray = pangram.Split(" ");
string reversedPangram = "";

foreach (string word in wordArray)
{
    char[] charWord = word.ToCharArray();
    Array.Reverse(charWord);
    string newWord = new(charWord);
    reversedPangram = string.Concat(reversedPangram, newWord);
}

Console.WriteLine(reversedPangram);