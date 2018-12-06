using System;
namespace University
{
    public class Master : Student
    {
        private bool hasAJob;

        public bool HasAJob{
            get { return HasAJob; }
            set { hasAJob = value; }
        }

        public Master(string firstName, string lastName, int age, int course) : base(firstName, lastName, age, course)
        {
        }
    }
}
