using Results;
using System;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Pranav",
                Subject = "Maths",
                MarksObtained = 58
            };

            Console.WriteLine(student.Id + " " + student.Name + " " + student.Subject + " " + student.MarksObtained);
        }
    }
}
