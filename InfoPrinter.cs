using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InfoPrinter : IPrinter
    {
        public void PrintAverage(double average)
        {
            Console.WriteLine($"Average mark: {average}\n ");
        }
        public void PrintMin(int min)
        {
            Console.WriteLine($"Min mark: {min}");
        }
        public void PrintMax(int max)
        {
            Console.WriteLine($"Max mark: {max}");
        }
        public void PrintBasicInfo(Student student)
        {
            Console.WriteLine(student.ToString());
        }
        public void PrintAge(AgeStruct age)
        {
            Console.WriteLine($"Date of birth: {age.dateOfBirth}\nFull years: {age.age}\n");
        }
    }
}
