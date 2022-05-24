using ArraysAndLoopsExercises;

bool keepThinking = true;
while (keepThinking)
{
    Console.Clear();
    Console.WriteLine("ARRAYS AND LOOPS EXERCISES\n");
    Console.WriteLine("Which exercise would you like to run?");
    Console.WriteLine("1. Sort the Numbers");
    Console.WriteLine("2. Which Day of the Week?");
    Console.WriteLine("3. Find the Smallest Number in an Array");
    Console.WriteLine("4. Shopping List");
    Console.WriteLine("5. What's the Longest Word?");
    Console.WriteLine("6. What's the Second to Last Word?");
    Console.WriteLine("7. Print a Triangle");
    Console.WriteLine("8. Common Values");
    Console.WriteLine("Press Q to quit");

    string userChoice = Console.ReadLine().ToLower();

    switch (userChoice)
    {
        case "1":
            Exercises.SortTheNumbers();
            break;
        case "2":
            Exercises.WhichDayOfWeek();
            break;
        case "3":
            Exercises.SmallestNumberInArray();
            break;
        case "4":
            Exercises.ShoppingList();
            break;
        case "5":
            Exercises.LongestWord();
            break;
        case "6":
            Exercises.SecondToLastWord();
            break;
        case "7":
            Exercises.PrintTriangle();
            break;
        case "8":
            Exercises.CommonValues();
            break;
        case "q":
            keepThinking = false;
            Console.WriteLine("Good bye!");
            break;
        default:
            break;
    }
}