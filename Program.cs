using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breshna_Loop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parallel Arrays
            string[] names = { "Will", "Breshna", "Sam", "Ronda" };
            int[] grades = { 52, 100, 100, 100 };
            string[] role = { "Teacher", "Tutor", "Student", "Student"};


            // Will - 52 - Teacher
            // Breshna - 100 - Tutor


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {grades[i]} - {role[i]}");
            }

        
            Console.ReadKey();
        } // Main

        public void LinearSearch()
        {
            int[] number = { 5, 3, 8, 0, 1 };

            // A linear search checks a collection 
            // ( Array is a collection )

            int search = 20;

            for (int i = 0; i < number.Length; i++)
            {
                // What: Display a number if it exists in our collection

                if (search == number[i])
                {
                    Console.WriteLine(number[i]);
                }

            }

        }

        public void BrushTeethExample()
        {
            // Brush Teeth
            // Get brush ( if you have brush )
            // Operation: Add toothpaste to brush
            // 1 Tooth
            // While( tooth is dirty )

            int numberOfTeeth = 5;
            Random rand = new Random();

            for (int i = 0; i < numberOfTeeth; i++)
            {
                Console.WriteLine($"Brushing tooth number {i}: ");

                int toothClean = 0;



                while (toothClean < 100)
                {

                    if (rand.Next() % 2 == 0)
                    {
                        toothClean += 2;
                    }
                    else
                    {
                        toothClean += 5;
                    }
                    Console.Write($"{toothClean}% ");
                }

                Console.WriteLine();
            }

        }

        public void LoopMenuExample()
        {
            // Are asking a question over and over again
            // Are we checking to see if something has changed over and over again

            // Are we preforming the same operation over and over again

            // Let's the user choose to quit
            //bool isRunning = true;

            //while(isRunning) // Infinite Loop
            //{
            //    Console.WriteLine("Enter a choice");
            //    Console.WriteLine("Choice 1");
            //    Console.WriteLine("Choice 2");
            //    Console.WriteLine("E to exit");
            //    Console.Write("Enter your choice");
            //    string userChoice = Console.ReadLine();

            //    // How the user stops the loop - Power to the user
            //    if(userChoice == "e")
            //    {
            //        isRunning = false;
            //    }


            //    Console.WriteLine(userChoice);
            //}
        }

        public void TryParseLoop()
        {
            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();

            int number;
            bool userNumber = int.TryParse(userInput, out number); // True or False
            // When does it return true? Is a valid number
            // When it is NOT a number ( is invalid ) it is false

            // Why?
            // TO keep asking the user for a number, until they enter a valid number
            // This code asks your for a new number
            while (!userNumber) // 
            {
                Console.WriteLine("Please Enter a valid number.");
                userNumber = int.TryParse(Console.ReadLine(), out number);

            }

            Console.WriteLine("You number was " + userNumber);
        }

    } // class

} // namespace
