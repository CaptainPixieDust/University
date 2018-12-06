using System;
using System.Collections.Generic;

namespace University
{
    public class Teacher
    {
        private string firstName;
        private string lastName;
        private Group group;
        private List<Subject> subjects;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Group Group
        {
            get { return group; }
            set { group = value; }
        }

        public List<Subject> Subjects
        {
            get { return subjects; }
        }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            subjects = new List<Subject>();
        }

        public void AddHours()
        {

        }

        public void AddSubjects(Subject subject)
        {
            subjects.Add(subject);
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
