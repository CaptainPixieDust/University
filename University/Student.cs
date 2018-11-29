using System;
namespace University
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName{
            get { return FirstName; }
            set { firstName = value; }
        }

        public string LastName{
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age{
            get { return age; }
            set { age = value; }
        }
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + age;
        }
    }
}
