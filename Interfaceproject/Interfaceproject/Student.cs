using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interfaceproject
{
    internal class Student:ICodeAcademy
    {
        public static int Count { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
      


        public string CodeEmail { get; set; }

       

        public Student()
        {

           
            Id = ++Count;
            
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Id:{Id}");
        }

        public override string ToString()
        {
            return $"Name:{Name} Surname:{Surname} Id:{Id}";
        }

        public static string Capitalize(string name,string surname)
        {

            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower() + " " + surname.Substring(0, 1).ToUpper() + surname.Substring(1).ToLower();
        }

        public static bool CheckName(string name)
        {
          for(int i = 0; i < name.Length; i++)
            {
                if (Char.IsLetter(name[i]) && name.Length>=3 && name.Length <= 25)
                {
                    return true;
                }
              
            }
            return false;
        }

        public void GenerateEmail()
        {
            string email = Name.Substring(0).ToLower() + "." + Surname.Substring(0).ToLower() + Id + "@code.edu.az";
            Console.WriteLine(email);
        }

        
    }
}