using GradeBook.Enums;
using GradeBook.GradeBooks;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5) 
            {
                throw new InvalidOperationException("Ranked grading requires at least 5 students.");
            }

            var percentGrade = averageGrade * 0.2 / 100;

            if(percentGrade <= averageGrade)
            {
                return 'A';
            }

            else if (percentGrade * 2 <= averageGrade)
            {
                return 'B';
            }

            else if (percentGrade * 3 <= averageGrade)
            {
                return 'C';
            }

            else if (percentGrade * 4 <= averageGrade)
            {
                return 'D';
            }
            return 'F';
        }
    }
}
