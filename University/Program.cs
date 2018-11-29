using System;
using System.Collections.Generic;

namespace University
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Faculty faculty = new Faculty();
            Console.WriteLine("Enter faculty name:");
            faculty.facultyName = Console.ReadLine();

            bool done = false;

            while(!done){
                Console.WriteLine("Choose action:\n1 - Add Speciality \n2 - Add group \n3 - Add students to grounp");
                int ans;
                string str;

                int.TryParse(Console.ReadLine(), out ans);
                switch(ans){
                    case 1:
                        Console.WriteLine("Choose speciality name:");
                        str = Console.ReadLine();
                        AddSpeciality(str, faculty);
                        break;
                    case 2:
                        Console.WriteLine("Enter group name:");
                        str = Console.ReadLine();
                        Console.WriteLine("Enter number of students");
                        int.TryParse(Console.ReadLine(), out ans);
                        AddGroup(ans, str, SelectSpeciality(faculty.specialities));
                        break;
                    case 3:
                        Group group = SelectGroup(SelectSpeciality(faculty.specialities).groups);
                        AddStudents(group);
                        break;
                }

                Console.WriteLine("to exit press e");
                str = Console.ReadLine();
                if(str == "e")
                    done = true;
            }

            Group group1 = SelectGroup(SelectSpeciality(faculty.specialities).groups);
            ShowStudentsList(group1);
        }

        //for future
        public static void AddFaculty(string name){
            
        }

        public static void AddSpeciality(string name, Faculty faculty){
            faculty.specialities.Add(new Speciality(name));
        }

        public static void AddGroup(int studentsCount, string name, Speciality speciality){
            speciality.groups.Add(new Group(name, studentsCount));
        }

        public static void AddStudents(Group group){
            for (int i = 0; i < group.numberOfStudents; i++)
            {
                Console.WriteLine("Enter student's name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student's surname");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter studants age");
                int age;
                int.TryParse(Console.ReadLine(), out age);
                group.students.Add(new Student(name, surname, age));
            }
        }

        public static Speciality SelectSpeciality(List<Speciality> specialities){
            if(specialities.Count == 1){
                return specialities[0];
            }
            int index;
            Console.WriteLine("Select a speciality:");

            for (int i = 0; i < specialities.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {specialities[i].name}");
            }
            int.TryParse(Console.ReadLine(), out index);

            return specialities[index - 1];
        }

        public static Group SelectGroup(List<Group> groups){
            if(groups.Count == 1){
                return groups[0];
            }

            int index;
            Console.WriteLine("Select a group:");
            for (int i = 0; i < groups.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {groups[i].groupName}");
            }
            int.TryParse(Console.ReadLine(), out index);

            return groups[index - 1];
        }

        public static void ShowStudentsList(Group group){
            foreach (var student in group.students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
