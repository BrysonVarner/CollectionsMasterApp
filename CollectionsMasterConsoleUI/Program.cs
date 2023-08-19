using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            var numbers = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
            Console.WriteLine("Here is the first number in my new array.");
            Console.WriteLine("-------------------");
            Console.WriteLine($"{numbers[0]}");

            //TODO: Print the last number of the array
            //
            Console.WriteLine("-------------------");
            Console.WriteLine("Here is the final number in my new array.");
            Console.WriteLine("-------------------");
            Console.WriteLine($"{numbers[numbers.Length - 1]}");

            Console.WriteLine("-------------------");
            Console.WriteLine("All Numbers Original");
            Console.WriteLine("-------------------");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____();             
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            
            Array.Reverse(numbers);
            NumberPrinter(numbers);
            
            Console.WriteLine("-------------------");
            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            Console.WriteLine("-------------------");

            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Console.WriteLine("-------------------");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            var numberList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine("This is how many things can be put in the list before it must resize itself when it is newly created.");
            Console.WriteLine("-------------------");
            Console.WriteLine(numberList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numberList);

            Console.WriteLine("-------------------");
            Console.WriteLine("Now that we have items in the list, the maximum size automatically increased to this...");
            //TODO: Print the new capacity

            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            var searchEntry = Console.ReadLine();

            if (true == int.TryParse(searchEntry,out int searchNumber))
            {

            NumberChecker(numberList, searchNumber);
            } 
            else
            {
                Console.WriteLine($"Sorry, {searchEntry} is not a acceptable number!");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            Console.WriteLine("-------------------");
            //UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(numberList);
            
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            Console.WriteLine("-------------------");

            OddKiller(numberList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            Console.WriteLine("-------------------");

            numberList.Sort();
            NumberPrinter(numberList);


            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            int[] listToArray = numberList.ToArray();

            //TODO: Clear the list

            numberList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (var parameter in numbers)
            {
                if (parameter % 3 == 0)
                {
                    numbers[parameter] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >=0 ; i-- ) 
            {
                if (numberList[i] % 2 != 0) 
                {
                    numberList.Remove(numberList[i]);
                }                
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            int foundNum = 0;
            foreach (var num in numberList) 
            { 
                if (searchNumber == num)
                    {
                    foundNum++;
                    }

            }
            if (foundNum > 0)
            {
                Console.WriteLine($"The number {searchNumber} was located in this list {foundNum} times.");
            } 
            else
            {
                Console.WriteLine($"Sorry, The number {searchNumber} was not found in this list.");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            for (int i = 0; i < 50; i++) 
            {
                Random rng = new Random();
                numberList.Add(rng.Next(0, 51));
            }
            
        }

        private static void Populater(int[] numbers)
        {
            
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 51);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
