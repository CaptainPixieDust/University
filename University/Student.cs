using System;
namespace University
{
    public abstract class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int course;

        public string FirstName
        {
            get { return FirstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public Student(string firstName, string lastName, int age, int course)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + age;
        }
    }
}
