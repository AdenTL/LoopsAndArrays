using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLoopsExercises
{
    internal class Exercises
    {
        public static void SortTheNumbers()
        {
            // Ask 10 people for their favorite numbers and create an array of those numbers. 
            // Order the numbers using the sort method. Print the first and last numbers.

            Console.Clear();
            Console.WriteLine("SORT THE NUMBERS\n");

            // Enter your solution here
            int[] favoriteNumbers = new int[10];
            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine("Please enter your favorite number: ");
                favoriteNumbers[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(favoriteNumbers[favoriteNumbers.Length - 1]);
            
         

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichDayOfWeek()
        {
            // Declare and initialize a string array with the 7 days of the week. 
            // Print the number corresponding to each day and the day of the week. (1 = Sunday, 2 = Monday, etc.)

            // Ask the user for a number between 1 - 7.
            // Print the day of the week that corresponds to the number

            Console.Clear();
            Console.WriteLine("WHICH DAY OF THE WEEK?\n");

            // Enter your solution here
            string[] daysOfWeek = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            for(int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(i + 1);
            }
            while (true)
            {
                Console.WriteLine("Please enter a number 1 - 7");
                int userInput = Int32.Parse(Console.ReadLine());

                Console.WriteLine(daysOfWeek[userInput - 1]);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SmallestNumberInArray()
        {
            // Ask the user for 5 integers and save them in an array. 
            // Find the smallest number in the array and write it to the screen.

            Console.Clear();
            Console.WriteLine("FIND THE SMALLEST NUMBER IN AN ARRAY\n");

            // Enter your solution here
            int[] arrInt = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter an integer: ");
                arrInt[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("The smallest number is: " + arrInt.Min());
  
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        public static void ShoppingList()
        {
            // Initialize an array with 4 food items. Print this shopping list to the console.

            Console.Clear();
            Console.WriteLine("SHOPPING LIST\n");

            // Enter your solution here
            string[] arrFood = new string[] {"Onions", "Tomatos", "Lettuce", "Pickles"};
            Array.ForEach(arrFood, Console.WriteLine);   //this is COOL

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void LongestWord()
        {
            // Ask the user for a phrase consisting of 1-4 words (no punctuation).
            // Print the longest word in the phrase. If 2 words have the same length, print both.

            Console.Clear();
            Console.WriteLine("WHAT'S THE LONGEST WORD?\n");

            // Enter your solution here
            Console.WriteLine("Type in a phrase thats one to four words long (no punctuation)");
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');
            string longestWordTwo = "";
            string longestWord = "";
            int longestLength = 0;
            for(int i = 0; i < words.Length; i++)
            {
                int length = words[i].Length;
                if (length > longestLength)
                {
                    longestWord = words[i];      
                    longestLength = length;
                }
                else if (length == longestLength)
                {
                    longestWordTwo = words[i];
                }
            }
            Console.WriteLine(longestWord + ' ' + longestWordTwo);
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SecondToLastWord()
        {
            // Ask the user for a sentence or phrase consisting of at least 4 words.
            // Find the second to last word and print it.

            Console.Clear();
            Console.WriteLine("WHAT'S THE SECOND TO LAST WORD?\n");

            // Enter your solution here
            Console.WriteLine("Type in a sentence with at least four words.");
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');
            string secondToLast = "";
            for(int i = 0; i < words.Length; i++)
            {
                secondToLast = words[i];               //this turns secondToLast into whatever word the loop is at. i need it to print the 
            }                                          //second to last index. i - 2 dosent work that way... thatd be too easy
            Console.WriteLine(words);
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void PrintTriangle()
        {
            // Ask the user for a number between 3 and 6. 
            // Print one asterisk to the screen. 
            // On the next line print 2 asterisks, and continue until the users number is reached.

            Console.Clear();
            Console.WriteLine("PRINT A TRIANGLE\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void CommonValues()
        {
            // You are given 3 arrays of the same size, where 1 is empty and 2 have values. 
            // Use nested loops to find the values that are common between the 2 arrays.

            Console.Clear();
            Console.WriteLine("COMMON VALUES\n");

            // Enter your solution here
            int commonValue = 0;
            int[] arrayOne = new int[] {1, 2, 3, 4, 5};
            int[] arrayTwo = new int[] {3, 6, 7, 2, 1};
            for(int i = 0; i < arrayTwo.Length; i++)
            {
                for (int j = 0; j < arrayOne.Length; j++)                   // dosent update commonValue anywhere
                {
                    if (arrayOne[j] == arrayTwo[i])
                    {
                        commonValue = 0;
                    }
                }
            }
            Console.WriteLine(commonValue);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
