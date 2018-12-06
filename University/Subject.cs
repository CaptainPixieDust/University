using System;
namespace University
{
    public class Subject
    {
        private string name;
        private int hours;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public Subject(string name)
        {
            Name = name;
            Hours = hours;
        }
    }
}
