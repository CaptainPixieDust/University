using System;
using System.Collections.Generic;

namespace University
{
    public class Faculty
    {
        IWriter _logWriter;
        public string facultyName;
        public List<Speciality> specialities;
        public List<Teacher> teachers;

        public Faculty(IWriter writer)
        {
            _logWriter = writer;
            teachers = new List<Teacher>();
            specialities = new List<Speciality>();
        }

        public void AddSpeciality(string name)
        {
            specialities.Add(new Speciality(name));
        }

        public void AddTeachers()
        {
            Console.WriteLine("Enter teachers first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter teachers last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter subject name");
            string subName = Console.ReadLine();
            Teacher teacher = new Teacher(firstName, lastName);
            teachers.Add(teacher);
        }

        private void ShowTeachersList()
        {
            foreach (var item in teachers)
            {
                _logWriter.WriteInfo(teachers.ToString());
            }
        }

        public void ShowSpecialities()
        {
            foreach (var item in specialities)
            {
                _logWriter.WriteInfo(specialities.ToString());
            }
        }

        public void ShowStudentsList()
        {
            for (int i = 0; i < specialities.Count; i++)
            {

            }
        }

        public bool IsSubjectExist(string subjectName)
        {

            for (int i = 0; i < specialities.Count; i++)
            {
                for (int j = 0; j < specialities[i].subjects.Count; j++)
                {
                    if (specialities[i].subjects[j].Name == subjectName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
