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

        public void AddGroup(int studentsCount, string name)
        {
            groups.Add(new Group(name, studentsCount));
        }

        public override string ToString()
        {
            return name;
        }
    }
}
