// // https://learn.microsoft.com/en-gb/training/modules/csharp-do-while/3-exercise-challenge-do-while-statements
// // Exercise 8 - Complete a challenge activity using do and while iteration statements

// int HeroHealth = 10, MonsterHealth = 10;
// Random HeroAttack = new();
// Random MonsterAttack = new();

// do
// {
//     int HeroDamage = HeroAttack.Next(1, 11);
//     MonsterHealth -= HeroDamage;
//     Console.WriteLine($"Monster was damanged and lost {HeroDamage} health and now has {MonsterHealth} health.");
//     if (MonsterHealth > 0)
//     {
//         int MonsterDamage = MonsterAttack.Next(1, 11);
//         HeroHealth -= MonsterDamage;
//         Console.WriteLine($"Hero was damanged and lost {MonsterDamage} health and now has {HeroHealth} health.");
//     }


// } while (HeroHealth > 0 && MonsterHealth > 0);

// if (HeroHealth <= 0)
// {
//     Console.WriteLine("Monster wins!");
// }
// else
// {
//     Console.WriteLine("Hero wins!");
// }



// // Solution from Microsoft after I submitted my own

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");