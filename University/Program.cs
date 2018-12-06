using System;
using System.Collections.Generic;

namespace University
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ConsoleWriter writer = new ConsoleWriter();
            Faculty faculty = new Faculty(writer);
            Console.WriteLine("Enter faculty name:");
            faculty.facultyName = Console.ReadLine();

            bool done = false;

            while (!done)
            {
                Console.WriteLine("Choose action:\n1 - Add Speciality \n2 - Add group \n3 - Add students to grounp \n4 - Add teachers");
                int ans;
                string str;

                int.TryParse(Console.ReadLine(), out ans);
                switch (ans)
                {
                    case 1:
                        Console.WriteLine("Choose speciality name:");
                        str = Console.ReadLine();
                        faculty.AddSpeciality(str);
                        break;
                    case 2:
                        Console.WriteLine("Enter group name:");
                        str = Console.ReadLine();
                        Console.WriteLine("Enter number of students");
                        int.TryParse(Console.ReadLine(), out ans);
                        Speciality speciality = SelectSpeciality(faculty.specialities);
                        speciality.AddGroup(ans, str);
                        break;
                    case 3:
                        Group group = SelectGroup(SelectSpeciality(faculty.specialities).groups);
                        group.AddStudents();
                        break;
                        //case 4:
                        //faculty.
                }

                Console.WriteLine("to exit press e");
                str = Console.ReadLine();
                if (str == "e")
                    done = true;
            }

            Group group1 = SelectGroup(SelectSpeciality(faculty.specialities).groups);
            ShowStudentsList(group1);
        }

        //for future
        public static void AddFaculty(string name)
        {

        }

        public static Speciality SelectSpeciality(List<Speciality> specialities)
        {
            if (specialities.Count == 1)
            {
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

        public static Group SelectGroup(List<Group> groups)
        {
            if (groups.Count == 1)
            {
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

        public static void ShowStudentsList(Group group)
        {
            foreach (var student in group.students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
