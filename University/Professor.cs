using System;
namespace University
{
    public class Professor : Teacher
    {
        private int numberOfTheses;
        public int NumberOfTheses{
            get { return numberOfTheses; }
            set { numberOfTheses = value; }
        }

        public Professor(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}
