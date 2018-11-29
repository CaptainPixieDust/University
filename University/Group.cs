using System;
using System.Collections.Generic;

namespace University
{
    public class Group
    {
        public string groupName;
        public int numberOfStudents;
        public List<Student> students;
        //private List<Subject> subjects;

        public Group(/*List<Subject> subjects*/ string name, int count)
        {
            groupName = name;
            numberOfStudents = count;
            students = new List<Student>();
            //this.subjects = subjects;
        }

        /*public void PrintSubjects(){
            foreach (var item in subjects)
            {
                Console.WriteLine(item.name);
            }
        }*/

        public void AddStudent(Student student){
            students.Add(student);
        }
    }
}
