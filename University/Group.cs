using System;
using System.Collections.Generic;

namespace University
{
    public class Group
    {
        public string groupName;
        public int numberOfStudents;
        public List<Student> students;

        public Group(string name, int count)
        {
            groupName = name;
            numberOfStudents = count;
            students = new List<Student>();
        }

        public void AddStudents()
        {
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Enter student's name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student's surname");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter studants age");
                int age;
                int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine("Enter student's course");
                int course;
                int.TryParse(Console.ReadLine(), out course);
                students.Add(CreateStudents.CreateStudent(name, surname, age, course));
            }
        }
    }
}
