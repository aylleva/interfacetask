namespace Interfaceproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Group group=new Group { GroupName="KE023S2"};
           
            string name = "anora";
            string surname = "ga";

            if(Student.CheckName(name) && Student.CheckName(surname))
            {
                Student student4 = new Student { Name = name, Surname = surname };
                Console.WriteLine($"Name:{student4.Name} Surname:{student4.Surname} Id:{student4.Id}");

             
            }
            
            else
            {
               
                Console.WriteLine("We may not create this student.Please check the rules!!");
            }

            
            Student student = new Student { Name = "Ayla", Surname = "Atakisiyeva" };
            Student student2 = new Student { Name = "Nezrin", Surname = "Ismayilova" };
            Student student3= new Student { Name = "Zerife", Surname = "Eliyeva" };
           

            group.GroupGetInfo();

            Student.Count = 0;
            Group group2 = new Group { GroupName = "BP217" };

            Student student5 = new Student { Name = "Ismayil", Surname = "Ibrahimzade" };
            Student student6 = new Student { Name = "Mehin", Surname = "Rehimli" };
            Student student7 = new Student { Name = "Azad", Surname = "Ashurov" };
            Student student8 = new Student { Name = "Huseyn", Surname = "Abbasov" };


            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(student3);

            group.ShowStudents();

            group2.AddStudent(student5);
            group2.AddStudent(student6);
            group2.AddStudent(student7);
            group2.AddStudent(student8);


            Console.WriteLine("----------------------------");
            group2.GroupGetInfo();



            //Console.WriteLine(group.GetStudentID(2));
            //group.Searh("gaf");

            //group.RemoveStudentId(2);

           
          

            group2.ShowStudents();
            //student.GetInfo();
            //student.GenerateEmail();

            //Group.ShowAllGroups();
            //Console.WriteLine(Student.Capitalize("aYlA", "ATAKISIYEVA"));








        }
    }
}