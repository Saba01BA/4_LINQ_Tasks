using System.Text.RegularExpressions;

namespace Student_Grade_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<(string Name, int Grade)>
                {
                    ("Alice", 87), ("Bob", 43), ("Charlie", 91),
                    ("David", 56), ("Eve", 78), ("Frank", 91),
                    ("Grace", 34), ("Henry", 67), ("Isla", 91), 
                    ("Jack", 78) , ("Saba", 99), ("Tekla", 100)
                };

            /* Using LINQ, find and print:

                   1. All students who passed (grade >= 50), ordered by grade descending
                   2. The top 3 students
                   3. The average grade of the whole class
                   4. How many students got each unique grade (group by grade)
                   5. All students whose name starts with a vowel */

            //Task N1

            var overFifty = students.Where(x => x.Grade >= 50).OrderByDescending(x=>x.Grade);
            Console.WriteLine(string.Join("\n ", overFifty));

            //Task N2

            var topThree = students.OrderByDescending(x => x.Grade).Take(3);
            Console.WriteLine($"Top Three Students: {string.Join(",", topThree)}");

            //Task N3

            var average = students.Average(x => x.Grade);
            Console.WriteLine($"The average of the Whole Class is:{average} ");

            //Task N4

            var uniqueGrade = students.GroupBy(x => x.Grade); // group students by their GRADE value

            foreach (var group in uniqueGrade)
            {
                // group.Key = the grade value, group.Count() = how many students share that grade
                Console.WriteLine($"Grade {group.Key}: {group.Count()} Student(s)");
            }

            //Task N5
            // x.Name[0] gets the first character of the name, Contains checks if it's a vowel
            var vowelName = students.Where(x => "AEIOUaeiou".Contains(x.Name[0]));
            Console.WriteLine(string.Join("\n", vowelName));

        }
    }
}
