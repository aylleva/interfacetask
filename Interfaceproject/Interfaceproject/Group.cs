using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaceproject
{
    internal class Group

    {
        public  static Group[] groups = new Group[0];
        public static int GroupCount { get; set; } = 0;
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public Student[] students = new Student[0];


        public Group()
        {
            GroupId = ++GroupCount;
        }

        public void GroupGetInfo()
        {
            Console.WriteLine($"GroupId:{GroupId} GroupName:{GroupName} StudentsCount:{Student.Count}");
        }

        public override string ToString()
        {
            return $"GroupId:{GroupId} GroupName:{GroupName} StudentsCount:{Student.Count}";
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length+1);
            students[students.Length - 1] = student;
        }
        public string  GetStudentID(int id)
        {
            for (int i = 0; i <= students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i].Name;
                }
            }
            return null;
           
        }

        public void Searh(string search)
        {
            for(int i = 0; i < students.Length; i++)
            {
               if(students[i].Name == search || students[i].Surname == search)
                {
                    Console.WriteLine(students[i].ToString());
                }
            }
        }

        public void RemoveStudentId(int id)
        {
            Student[] newarr=new Student[students.Length-1];

            int j = 0;
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i].Id != id)
                {
                    newarr[j] = students[i];
                    j++;
                }
            }
            students = newarr;

            
        }

        public void ShowStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Name:{students[i].Name} Surname:{students[i].Surname} Id:{students[i].Id}");

            }
        }

        public static void AddGroups(Group group)
        {
            Array.Resize(ref groups,groups.Length+1);
            groups[groups.Length - 1] = group;
        }

        public static void RemoveGroup(int id)
        {

            Group[] newarr = new Group[groups.Length - 1];

            int j = 0;
            for (int i = 0; i < groups.Length; i++)
            {
                if (groups[i].GroupId != id)
                {
                    newarr[j] = groups[i];
                    j++;
                }
            }
            groups = newarr;
        }
        public static void ShowAllGroups()
        {
            for(int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine(groups[i].ToString());
            }
        }




    }
}
