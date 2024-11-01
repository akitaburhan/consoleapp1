using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a one-dimensional array of strings
            string[] myArray = { "Hello", "World", "C#", "Programming" };

            // Step 2: Ask the user to input some text
            Console.Write("Please enter some text to add to each array element: ");
            string userInput = Console.ReadLine();

            // Step 3: Loop to iterate through each string in the array and add the user's text to the end
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] += userInput;
            }

            // Step 4: Second loop to print each string in the array one at a time
            Console.WriteLine("\nUpdated array elements:");
            foreach (string str in myArray)
            {
                Console.WriteLine(str);
            }

            // Step 5: Save and execute code
            // (This is my actual console output; no additional action is required here)
        }
    }
}