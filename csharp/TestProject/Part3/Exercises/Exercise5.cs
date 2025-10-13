// // Practice Exercise 5
// // For Loo[]

// // Basic loop
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// // Reverse loop
// for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);
// }


// // Experiment with different increments 
// for (int i = 0; i <= 20; i += 3)
// {
//     Console.WriteLine(i);
// }

// // Use the break keyword to break the iteration statemen
// for (int i = 0; i < 20 ; i++)
// {
//     Console.WriteLine(i);
//     if (i == 10)
//         break;
// }

// // Loop through each element of an array
// string[] names = ["Alice", "Bob", "Charlie", "David"];
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// // Limitation of foreach loop
// string[] fruits = ["Apple", "Banana", "Cherry"];
// foreach (string fruit in fruits)
// {
//     Console.WriteLine(fruit);
//     // fruit = "Orange"; // This will cause a compile-time error
//     // Can't do this:
//     // if (fruit == "David") fruit = "Sammy"; //  error CS1656: Cannot assign to 'fruit' because it is a 'foreach iteration variable'
// }

// // overcoming the limitation of foreach loop
// string[] fruits = ["Apple", "Banana", "Cherry"];
// for (int i = 0; i < fruits.Length; i++)
// {
//     if (fruits[i] == "Banana")
//         fruits[i] = "Mango"; // This is allowed
// }
// foreach (string fruit in fruits)
// {
//     Console.WriteLine(fruit);
// }