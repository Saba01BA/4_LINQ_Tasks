using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _4_LINQ_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Exercise 1
                Given a list of numbers, return only the numbers greater than 10.
                Input: 3 15 7 22 1 18
                Output: The list of Numbers over 10: 15 22 18

            Exercise 2
                Given a list of names, return only names that start with the letter "A".
                Input: Anna Bob Alice Mark Amy
                Output: Anna Alice Amy

            Exercise 3
                Given a list of numbers, return the top 3 largest numbers sorted descending.
                Input: 4 9 1 7 3 8 2
                Output: 9 8 7

            Exercise 4
                Given a list of words, group them by their length and display each group.
                Input: cat dog elephant hi bus
                Output:
                Length 3: cat dog bus
                Length 8: elephant
                Length 2: hi
            */

            #region Exercise 1

            Console.WriteLine("Enter size of a list");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the number on position {i+1}");
                nums[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            var overTen = nums.Where(x => x > 10); // LINQ Where() filters a collection by a condition (x => x > 10) is a lambda expressionY

            if (overTen.Count() == 0)  // LINQ Count() returns the number of elements in the collection
            {
                Console.WriteLine("No number found over ten");                
            }
            else 
            { 
            Console.WriteLine($"The list of Numbers over 10: {string.Join(" ", overTen)}");
            }

            #endregion

            #region Exercise 2

            Console.WriteLine("Please enter size of your Contact list");
            int size1 = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[size1];
            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine($"Enter Name on Position Number {i + 1}");
                names[i] = Console.ReadLine().Trim();
            }
            // Where() filters the collection
            // StartsWith() is a string method that checks the first character
            // ToLower() ensures case-insensitive comparison while keeping ORIGINAL INPUT bro
            var namesA = names.Where(x => x.ToLower().StartsWith("a")); 
            if (namesA.Count() == 0)
            {
                Console.WriteLine("There were no Names starting with A");
            }
            else
            {
                Console.WriteLine($"The list of Names starting with A: {string.Join(" ",namesA)}");
            }


            #endregion

            #region Exercise 3

            Console.WriteLine("Enter Size of your Array");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] nums1 = new int[size2];
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine($"Enter a whole Number on Position {i+1}");
                nums1[i] = Convert.ToInt32(Console.ReadLine());
            }
            // OrderByDescending() sorts collection from largest to smallest 
            // Take(3) returns only the first 3 elements 
            // lambda x => x means "sort by the value itself"
            var result = nums1.OrderByDescending(x => x).Take(3);

            Console.WriteLine($"The Largest 3 Numbers are: {string.Join(" ",result)}");

            #endregion

            #region Exercise 4
            #endregion

        }
    }
}
