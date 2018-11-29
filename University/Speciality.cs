using System;
using System.Collections.Generic;
namespace University
{
    public class Speciality
    {
        public string name;
        public List<Group> groups;
        public List<Subject> subjects;

        public Speciality(string n)
        {
            name = n;
            groups = new List<Group>();
            subjects = new List<Subject>();
        }


    }
}
