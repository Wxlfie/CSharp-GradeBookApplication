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
                throw new InvalidOperationException();
            }

            if(averageGrade > 80)
            {
                return 'A';
            }

            if (averageGrade > 61 && averageGrade < 79)
            {
                return 'B';
            }

            if (averageGrade > 41 && averageGrade < 59)
            {
                return 'C';
            }
            return 'F';
        }
    }
}
