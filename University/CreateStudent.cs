using System;
namespace University
{
    public static class CreateStudents
    {
        public static Student CreateStudent(string firstName, string lastName, int age, int course){
            Student student;
            if(course > 4){
                student = new Master(firstName, lastName, age, course);
            }
            else{
                student = new Bachelor(firstName, lastName, age, course);
            }

            return student;
        }
    }
}
