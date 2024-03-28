using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace class_room.Models
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public Boolean isGraducated;


        public Student(string name, string surname,string group, int point)
        {
            Name = name;
            Surname = surname;  
            Group = group;
            Point = point;



        }
        public  Student(Boolean isgraducated)
        {

            isGraducated=isgraducated;


        }
        public void Getinfo()
        {

            Console.WriteLine($"{Group}-{Name} {Surname} {Point} ");

        }
        public  void CheckGraduation()
        {
            if (Point < 65)
            {
                Console.WriteLine("kesilib");
            }
            else
            {
                Console.WriteLine("mezundu");
            }

        }
        public  void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("yoxdur");
            }
            else if (Point > 65 && Point < 80)
            {
                Console.WriteLine("adi");
            }
            else if (Point > 80 && Point < 90)
            {
                Console.WriteLine("seref");
            }
            else 
            {
                Console.WriteLine("yusey seref");
            }
        }

    }
}
