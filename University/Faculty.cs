using System;
using System.Collections.Generic;

namespace University
{
    public class Faculty
    {
        public string facultyName;
        public List<Speciality> specialities;
        public List<Teacher> teachers;

        public Faculty()
        {
            teachers = new List<Teacher>();
            specialities = new List<Speciality>();
        }

        private void TeachersCount(){
            
        }

        public void StudentsCount(){
            
        }

        public void SubjectsCount(){
            
        }
    }
}
