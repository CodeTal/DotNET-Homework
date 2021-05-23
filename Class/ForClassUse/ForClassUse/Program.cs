using System;
using System.IO;
using System.Collections.Generic;

namespace Q2_app
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo si = new StudentInfo();
            Console.WriteLine("The average grade is: {0}", si.Average);
            Console.ReadKey();
        }
    }

    public class StudentInfo
    {

        public double Average;

        public StudentInfo()
        {
            Average = CaptureStudentInfo();
        }

        public double CaptureStudentInfo()
        {
            var students = new List<Student>();
            var adding = true;
            while (adding)
            {
                var newStudent = new Student();
                try
                {
                    Console.WriteLine("Student name: ");
                    newStudent.Name = Console.ReadLine();

                    Console.Write("Student ID: ");
                    newStudent.Name = Console.ReadLine();

                    Console.Write("Student grade (0-100): ");
                    newStudent.Grade = Double.Parse(Console.ReadLine());

                    students.Add(newStudent);
                    Student.Count++;

                    Console.Write("Add another (y/n)?");
                    if (Console.ReadLine() != "y")
                        adding = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid number");
                }

            }

            double totalGrade = 0;
            foreach (var s in students)
            {
                totalGrade += s.Grade;
            }
            var student = new Student();
            return (totalGrade / Student.Count);

        }
    }


    class Student
    {
        public string Name;
        public string ID;
        public double Grade;
        static public int Count = 0;
        public Student()
        {
            Name = "";
            ID = "";
            Grade = 0;
        }

        public Student(string name, string id, double grade)
        {
            Name = name;
            ID = id;
            Grade = grade;
        }

    }
}