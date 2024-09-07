
using System;
using System.Collections.Generic;

namespace StudentApp
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<double> Grades { get; set; }

        // Constructor to initialize the list
        public Student()
        {
            Grades = new List<double>();
        }

        // Method to add a single grade
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        // Method to add multiple grades using params
        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of Student class
            Student student = new Student
            {
                Name = "John Doe",
                ID = 12345
            };

            // Adding a single grade
            student.AddGrade(85.5);

            // Adding multiple grades
            student.AddGrade(90.2, 78.3, 88.9);

            Console.WriteLine($"Student: {student.Name}, ID: {student.ID}");
            Console.WriteLine("Grades: " + string.Join(", ", student.Grades));
        }
    }
}
