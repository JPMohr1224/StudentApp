
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

        // Method to calculate the average grade
        public double GetAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0; // If there are no grades, return 0
            }
            return Grades.Average();
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Student objects
            List<Student> students = new List<Student>();

            // Create 4 student instances
            Student student1 = new Student { Name = "John Doe", ID = 101 };
            Student student2 = new Student { Name = "Jane Smith", ID = 102 };
            Student student3 = new Student { Name = "Robert Brown", ID = 103 };
            Student student4 = new Student { Name = "Emily Davis", ID = 104 };

            // Add students to the list
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            // Example: Adding grades to the students
            student1.AddGrade(92.4);
            student2.AddGrade(76.9);
            student3.AddGrade(89);
            student4.AddGrade(91);
            student1.AddGrade(85.5, 90.3, 78.6);
            student2.AddGrade(88.4, 92.1);
            student3.AddGrade(79.0, 85.2, 91.5);
            student4.AddGrade(94.3, 87.8);

            // Output student data
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}, ID: {student.ID}");
                Console.WriteLine("Grades: " + string.Join(", ", student.Grades));
                 Console.WriteLine($"Average Grade: {student.GetAverageGrade():F2}");
                Console.WriteLine();
            }
        }
    }
}
