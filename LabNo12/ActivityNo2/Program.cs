using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab13_Activity
{
    class Program
    {
        static void Main()
        {
            
            foreach (var student in StudentClass.students)
            {
                student.AverageScore = GetAverageScore(student.ExamScores);
            }

         
            for (int examIndex = 0; examIndex < StudentClass.students[0].ExamScores.Count; examIndex++)
            {
                Console.WriteLine($"High scores for exam {examIndex + 1}:");
                GetHighScores(StudentClass.students, examIndex);
            }

            
            foreach (var student in StudentClass.students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {GetPercentile(StudentClass.students, student.AverageScore):F2} percentile");
            }

            Console.ReadLine(); 
        }

       
        private static double GetAverageScore(List<int> scores)
        {
            if (scores.Count == 0)
            {
                return 0;
            }

         
            return Math.Round((double)scores.Sum() / scores.Count, 2);
        }

       
        private static void GetHighScores(List<StudentClass.Student> students, int examIndex)
        {
            
            var sortedStudents = students.OrderByDescending(s => s.ExamScores[examIndex]).ToList();

            for (int i = 0; i < 3 && i < sortedStudents.Count; i++)
            {
                Console.WriteLine($"{sortedStudents[i].FirstName} {sortedStudents[i].LastName}: {sortedStudents[i].ExamScores[examIndex]}");
            }
        }

        private static double GetPercentile(List<StudentClass.Student> students, double score)
        {
            int count = students.Count(s => s.AverageScore < score);
            return (double)count / students.Count * 100;
        }
    }

    public class StudentClass
    {
        public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public GradeLevel Year { get; set; }
            public List<int> ExamScores { get; set; }
            public double AverageScore { get; set; }

            public Student(string firstName, string lastName, int id, GradeLevel year, List<int> examScores)
            {
                FirstName = firstName;
                LastName = lastName;
                ID = id;
                Year = year;
                ExamScores = examScores;
                AverageScore = 0; 
            }
        }

        public static List<Student> students = new List<Student>()
        {
            new Student("Terry", "Adams", 120, GradeLevel.SecondYear, new List<int> { 99, 82, 81, 79 }),
            new Student("Padi", "Fakhouri", 121, GradeLevel.ThirdYear, new List<int> { 99, 86, 90, 94 }),
            new Student("Hanying", "Liang", 122, GradeLevel.FirstYear, new List<int> { 93, 92, 80, 94 }),
            new Student("Cesar", "Hernandez", 123, GradeLevel.FourthYear, new List<int> { 97, 89, 85, 89 }),
            new Student("Debra", "James", 124, GradeLevel.ThirdYear, new List<int> { 95, 72, 77, 80 }),
            new Student("Hugo", "K", 125, GradeLevel.SecondYear, new List<int> { 92, 90, 89, 92 }),
            new Student("Sven", "Smith", 126, GradeLevel.FirstYear, new List<int> { 98, 94, 96, 90 })
        };
     }   
}

           