// /*This program calculates and displays the exam scores, overall grades, letter grades, and extra credit points for a list of students based on their individual scores.*/

// int examAssignments = 5;

// string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "John", "Sarah", "Michael", "Laura", "David", "Eris"];

// int[] sophiaScores = [90, 86, 87, 98, 100, 64, 90];
// int[] andrewScores = [92, 89, 81, 96, 90, 89];
// int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 90];
// int[] loganScores = [90, 95, 87, 88, 96, 50];
// int[] beckyScores = [100, 100, 100, 100, 100, 100, 100, 100];
// int[] johnScores = [50, 60, 70, 80, 90, 100, 56, 89, 75];
// int[] sarahScores = [88, 92, 79, 95, 85, 90, 87, 91];
// int[] michaelScores = [78, 82, 85, 80, 75, 88, 90, 92];
// int[] lauraScores = [95, 90, 85, 80, 75, 70, 65, 60];
// int[] davidScores = [60, 65, 70, 75, 80, 85, 90, 95];
// int[] erisScores = [30, 33, 25, 46, 15, 20, 18, 29];


// int[] studentScores = new int[10];
// string currentStudentLetterGrade = "";

// Console.Clear();
// Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

// foreach (string currentStudent in studentNames)
// {
//     if (currentStudent == "Sophia")
//         studentScores = sophiaScores;
//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;
//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;
//     else if (currentStudent == "Logan")
//         studentScores = loganScores;
//     else if (currentStudent == "Becky")
//         studentScores = beckyScores;
//     else if (currentStudent == "John")
//         studentScores = johnScores;
//     else if (currentStudent == "Sarah")
//         studentScores = sarahScores;
//     else if (currentStudent == "Michael")
//         studentScores = michaelScores;
//     else if (currentStudent == "Laura")
//         studentScores = lauraScores;
//     else if (currentStudent == "David")
//         studentScores = davidScores;
//     else if (currentStudent == "Eris")
//         studentScores = erisScores;

//     int gradedAssignments = 0;
//     int gradedExtraCreditAssignments = 0;

//     int sumExamScores = 0;
//     int sumExamExtraCreditScores = 0;


//     decimal currentStudentExamScore = 0;
//     decimal currentStudentExtraCreditScore = 0;
//     decimal currentStudentOverallGrade = 0;
//     decimal currentStudentExtraCreditPoints = 0;

//     foreach (int score in studentScores)
//     {
//         gradedAssignments++;
//         if (gradedAssignments <= examAssignments)
//             sumExamScores += score;
//         else
//         {
//             gradedExtraCreditAssignments++;
//             sumExamExtraCreditScores += score;
//         }
//     }

//     currentStudentExamScore = (decimal)sumExamScores / examAssignments;
//     currentStudentExtraCreditScore = Math.Round((gradedExtraCreditAssignments > 0 ? (decimal)sumExamExtraCreditScores / gradedExtraCreditAssignments : 0), 1);
//     currentStudentOverallGrade = Math.Round(currentStudentExamScore + (currentStudentExtraCreditScore * 0.1m), 1);
//     currentStudentExtraCreditPoints = (decimal)sumExamExtraCreditScores / 10 / examAssignments;

//     if (currentStudentOverallGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentOverallGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentOverallGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentOverallGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentOverallGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentOverallGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentOverallGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentOverallGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentOverallGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentOverallGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentOverallGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentOverallGrade >= 60)
//         currentStudentLetterGrade = "D-";
//     else
//         currentStudentLetterGrade = "F";

//     Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentOverallGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({currentStudentExtraCreditPoints} pts)");
// }

// Console.WriteLine("\nPress Enter to exit...");
// Console.ReadLine();