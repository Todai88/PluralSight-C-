using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        protected List<float> _grades; 

        public GradeBook()
        {
            _name = "Empty";
            _grades = new List<float>();
        }

        public override void AddGrade(float grade)
        {
            _grades.Add(grade);
        }

        public List<float> getGrades()
        {
            return _grades;
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");
            GradeStatistics stats = new GradeStatistics();

            stats.HighestGrade = _grades.Max();
            stats.LowestGrade  = _grades.Min();
            stats.AverageGrade = _grades.Average();

            return stats;
        }

        public override IEnumerator GetEnumerator()
        {
            return _grades.GetEnumerator();
        }
        public override void WriteGrades(TextWriter dest)
        {

        }
    }
}
