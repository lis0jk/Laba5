using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfMarks = { 6, 7, 9, 10, 4 };
            int rank = 65;
            DiffStudent student1 = new DiffStudent("Lizaveta", UniversityType.BSUIR, FacultyType.CSN,
                SpecialityType.CSPT, rank, arrayOfMarks);
            AgeStruct student1Age;
            IPrinter info = new InfoPrinter();
            student1Age.age = 17;
            student1Age.dateOfBirth = "31.08.2002";
            info.PrintBasicInfo(student1);
            info.PrintAge(student1Age);
            GradesCalculator gradesCalculator = new GradesCalculator();
            var averageMark = gradesCalculator.FindAverage(arrayOfMarks);
            var min = gradesCalculator.FindMin(arrayOfMarks);
            var max = gradesCalculator.FindMax(arrayOfMarks);
            info.PrintMax(max);
            info.PrintMin(min);
            info.PrintAverage(averageMark);
        }
    }
}
