using System;
namespace University
{
    public class Assistant
    {
        private const int maxGroupSize = 5;
        private int workingHours;

        public int WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }

        public Assistant()
        {
        }
    }
}
