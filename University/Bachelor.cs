using System;
namespace University
{
    public class Bachelor : Student
    {
        private int notClosedSubjects;

        public int NotClosedSubjects{
            get { return notClosedSubjects; }
            set { notClosedSubjects = value; }
        }

        public Bachelor(string firstName, string lastName, int age, int course) : base(firstName, lastName, age, course)
        {
        }
    }
}
