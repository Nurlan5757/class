using class_room.Models;

namespace class_room
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student Nurlan= new Student("Nurlan","Abbasov","AB106",100);



            Nurlan.Getinfo();
            Nurlan.GetDiplomDegree();
            Nurlan.CheckGraduation();


            
        }
    }
}