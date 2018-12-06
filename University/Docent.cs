using System;
namespace University
{
    public class Docent : Teacher
    {
        private const int maxGroupSize = 15;
        private int workingHours;

        public int WorkingHours{
            get { return workingHours; }
            set { workingHours = value; }
        }

        public Docent(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
