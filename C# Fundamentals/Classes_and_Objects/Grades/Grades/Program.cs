using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();
            book.Name = "Bethany's Grade Book.";
            book.NameChanged += OnNameChanged;
            book.Name = "Joakim's Grade Book.";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            IGradeTracker book2 = CreateGradeBook();
            book2.AddGrade(54);
            book2.AddGrade(32.5f);

            WriteResults(book);
            Console.WriteLine("\n--BREAK--\n");
            WriteResults(book2);
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("All grades:");
            foreach(float grade in book)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("---\nStatistics:");
            Console.WriteLine($"Highest: {stats.AverageGrade}");
            Console.WriteLine($"Lowest: {stats.LowestGrade}"); 
            Console.WriteLine($"Average: {stats.HighestGrade}");
        }
        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade Book changed name from '{args.ExistingName}' to '{args.NewName}'");
        } 
    }
}
